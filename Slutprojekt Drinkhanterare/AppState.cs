using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using drinks_info.Models;
using Newtonsoft.Json;

namespace drinks_info
{
    //AppState hanterar all applikationstillstånd
    //samlar all data som behövs för att driva applikationen i en enda plats
    public class AppState
    {
        private const string CUSTOM_DRINKS_FILE = "custom_drinks.json";

        public List<Category> Categories { get; set; } = new List<Category>();

        public List<Drink> CurrentDrinks { get; set; } = new List<Drink>();

        public List<CustomDrink> CustomDrinks { get; set; } = new List<CustomDrink>();

        private Dictionary<string, string> drinkIdMap = new Dictionary<string, string>();

        public AppState()
        {
            LoadCustomDrinks();
        }

        //uppdaterar drinklistan och den interna ID-mappningen och anropas när användaren väljer en ny kategori
        public void SetCurrentDrinks(List<Drink> drinks)
        {
            CurrentDrinks = drinks ?? new List<Drink>();
            drinkIdMap.Clear();

            //bygger om ID-mappningen baserat på nya drinkar
            foreach (var drink in CurrentDrinks)
            {
                drinkIdMap[drink.strDrink] = drink.idDrink;
            }
        }

        //hämtar drink-ID från drinknamn och returnerar true om drink hittades, false annars
        public bool TryGetDrinkId(string drinkName, out string drinkId)
        {
            return drinkIdMap.TryGetValue(drinkName, out drinkId);
        }

        //lägger till en anpassad drink
        public void AddCustomDrink(CustomDrink drink)
        {
            //kontrollera om drinken redan finns och används för redigering, annars lägg till som ny
            var existing = CustomDrinks.FirstOrDefault(d => d.idDrink == drink.idDrink);
            if (existing != null)
            {
                //uppdaterae befintlig drink
                var index = CustomDrinks.IndexOf(existing);
                CustomDrinks[index] = drink;
            }
            else
            {
                //lägg till ny drink annars
                CustomDrinks.Add(drink);
            }
            SaveCustomDrinks();
        }

        //tar bort en anpassad drink
        public void RemoveCustomDrink(string drinkId)
        {
            CustomDrinks.RemoveAll(d => d.idDrink == drinkId);
            SaveCustomDrinks();
        }

        //sparar anpassade drinkar till en JSON-fil
        private void SaveCustomDrinks()
        {
            try
            {
                string json = JsonConvert.SerializeObject(CustomDrinks, Formatting.Indented);
                File.WriteAllText(CUSTOM_DRINKS_FILE, json);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error saving custom drinks: {ex.Message}");
            }
        }

        //laddar anpassade drinkar från JSON-fil
        private void LoadCustomDrinks()
        {
            try
            {
                if (File.Exists(CUSTOM_DRINKS_FILE))
                {
                    string json = File.ReadAllText(CUSTOM_DRINKS_FILE);
                    CustomDrinks = JsonConvert.DeserializeObject<List<CustomDrink>>(json) ?? new List<CustomDrink>();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading custom drinks: {ex.Message}");
            }
        }

        //rensar all data och återställer till initialt tillstånd
        public void Clear()
        {
            Categories.Clear();
            CurrentDrinks.Clear();
            drinkIdMap.Clear();
        }
    }
}
