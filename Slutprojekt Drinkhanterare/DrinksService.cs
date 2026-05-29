using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;
using drinks_info.Models;
using Newtonsoft.Json;
using RestSharp;

namespace drinks_info
{
    //ApiService - Abstrakt basklass som definierar gemensamt beteende för API-tjänster och implementerar arv då DrinksService kan ärva från denna
    public abstract class ApiService
    {
        //basadress för API
        protected string ApiBaseUrl { get; set; }

        //konstruktor som tar emot API-basadress
        protected ApiService(string apiBaseUrl)
        {
            ApiBaseUrl = apiBaseUrl;
        }

        protected virtual T MakeApiRequest<T>(string endpoint) where T : class
        {
            try
            {
                var client = new RestClient(ApiBaseUrl);
                var request = new RestRequest(endpoint);
                var response = client.ExecuteAsync(request).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string rawResponse = response.Content;
                    return JsonConvert.DeserializeObject<T>(rawResponse);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API Error in {endpoint}: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Full error: {ex}");
                return null;
            }
        }
    }

    //ärver metoder och beteende från ApiService
    public class DrinksService : ApiService
    {
        public DrinksService() : base("http://www.thecocktaildb.com/api/json/v1/1/")
        {
        }

        //hämtar alla drinkkategorier från CocktailDB API
        public virtual List<Category> GetCategories()
        {
            //använder den ärvda MakeApiRequest-metoden från ApiService
            var result = MakeApiRequest<Categories>("list.php?c=list");

            if (result != null && result.CategoriesList != null)
            {
                return result.CategoriesList;
            }

            return new List<Category>();
        }

        //hämtar en lista med drinkar för en specifik kategori från API
        public virtual List<Drink> GetDrinksByCategory(string category)
        {
            string encodedCategory = HttpUtility.UrlEncode(category);
            var result = MakeApiRequest<Drinks>($"filter.php?c={encodedCategory}");

            if (result != null && result.DrinksList != null)
            {
                return result.DrinksList;
            }

            return new List<Drink>();
        }

        //hämtar och visar detaljerna för en drink i tabellformat i konsolen
        internal void GetDrink(string drink)
        {
            var result = MakeApiRequest<DrinkDetailObject>($"lookup.php?i={drink}");

            if (result != null && result.DrinkDetailList != null && result.DrinkDetailList.Count > 0)
            {
                DrinkDetail drinkDetail = result.DrinkDetailList[0];
                List<object> prepList = new();

                string formattedName = "";

                foreach (PropertyInfo prop in drinkDetail.GetType().GetProperties())
                {
                    if (prop.Name.Contains("str"))
                    {
                        formattedName = prop.Name.Substring(3);
                    }

                    if (!string.IsNullOrEmpty(prop.GetValue(drinkDetail)?.ToString()))
                    {
                        prepList.Add(new
                        {
                            Key = formattedName,
                            Value = prop.GetValue(drinkDetail)
                        });
                    }
                }

                TableVisualisationEngine.ShowTable(prepList, drinkDetail.strDrink);
            }
        }

        //hämtar drinkdetaljer asynkront och anropar callback-funktioner när bild och detaljer är klara
        public virtual void GetDrinkDetails(string drinkId, Action<string> onDetailsLoaded, Action<string> onImageLoaded)
        {
            var result = MakeApiRequest<DrinkDetailObject>($"lookup.php?i={drinkId}");

            if (result != null && result.DrinkDetailList != null && result.DrinkDetailList.Count > 0)
            {
                DrinkDetail drinkDetail = result.DrinkDetailList[0];

                string details = FormatDrinkDetails(drinkDetail);
                onDetailsLoaded?.Invoke(details);

                //om en bild finns, skicka URL till bild-callback
                if (!string.IsNullOrEmpty(drinkDetail.strDrinkThumb))
                {
                    onImageLoaded?.Invoke(drinkDetail.strDrinkThumb);
                }
            }
        }

        //formaterar drinkdetaljer som namn, kategori, instruktioner och ingredienser till en läsbar textsträng
        protected virtual string FormatDrinkDetails(DrinkDetail drinkDetail)
        {
            //använder Environment.NewLine för att ha korrekt radbrytning på olika plattformar
            string nl = Environment.NewLine;

            string details = $"Name: {drinkDetail.strDrink}{nl}{nl}";

            details += "--- General info ---" + nl;
            details += $"Category: {drinkDetail.strCategory}{nl}";
            details += $"Alcoholic: {drinkDetail.strAlcoholic}{nl}";
            details += $"Glass: {drinkDetail.strGlass}{nl}{nl}";

            details += "--- Instructions ---" + nl;
            details += string.IsNullOrWhiteSpace(drinkDetail.strInstructions)
                ? "(No instructions)" + nl + nl
                : drinkDetail.strInstructions.Trim() + nl + nl;

            details += "--- Ingredients ---" + nl;

            bool anyIngredient = false;
            for (int i = 1; i <= 15; i++)
            {
                var ingredientProp = drinkDetail.GetType().GetProperty($"strIngredient{i}");
                var measureProp = drinkDetail.GetType().GetProperty($"strMeasure{i}");

                if (ingredientProp == null || measureProp == null)
                    continue;

                string ingredient = ingredientProp.GetValue(drinkDetail)?.ToString();
                string measure = measureProp.GetValue(drinkDetail)?.ToString();

                if (string.IsNullOrWhiteSpace(ingredient))
                    continue;

                anyIngredient = true;
                measure = string.IsNullOrWhiteSpace(measure) ? "" : measure.Trim() + " ";
                details += $"- {measure}{ingredient.Trim()}{nl}";
            }

            if (!anyIngredient)
            {
                details += "(No ingredients listed)" + nl;
            }

            return details.TrimEnd();
        }
    }
}
