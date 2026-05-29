using System;
using System.Collections.Generic;

namespace drinks_info.Models
{
    //CustomDrink.cs, Modell för användarens egna drinkar
    //denna klass lagrar drinkar som användaren själv har lagt till
    public class CustomDrink : Drink
    {
        public string Category { get; set; }

        public string Instructions { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public DateTime CreatedDate { get; set; }

        public string Alcoholic { get; set; }

        public string Glass { get; set; }

        //överskrider basklassens GetDescription() med en mer detaljerad implementering
        public override string GetDescription()
        {
            string alcoholicInfo = string.IsNullOrEmpty(Alcoholic) ? "N/A" : Alcoholic;
            return $"Custom Drink: {strDrink} ({Category}) - {alcoholicInfo}";
        }

        //överskrider basklassens GetDetailsAsText() 
        //CustomDrink visar mer detaljerad information än API-drinkar
        public override string GetDetailsAsText()
        {
            string nl = Environment.NewLine;
            string details = $"=== {strDrink} ==={nl}";
            details += $"Category: {Category}{nl}";
            details += $"Alcoholic: {Alcoholic}{nl}";
            details += $"Glass: {Glass}{nl}";
            details += $"Created: {CreatedDate:yyyy-MM-dd}{nl}";
            details += $"Instructions: {Instructions}{nl}";

            if (Ingredients.Count > 0)
            {
                details += $"Ingredients ({Ingredients.Count}):{nl}";
                foreach (var ingredient in Ingredients)
                {
                    details += $"  - {ingredient.Measure} {ingredient.Name}{nl}";
                }
            }

            return details.TrimEnd();
        }

        //överskrider basklassens IsValid() med striktare validering för custom drinkar
        public override bool IsValid()
        {
           
            if (!base.IsValid())
                return false;

            //mer strikt validering för custom drinkar för att undvika någon form av ofullständig eller ogiltig data som kan orsaka problem/krasch i applikationen
            return !string.IsNullOrEmpty(Category) &&
                   !string.IsNullOrEmpty(Instructions) &&
                   Ingredients.Count > 0 &&
                   !string.IsNullOrEmpty(Alcoholic) &&
                   !string.IsNullOrEmpty(Glass);
        }
    }

    //lagrar information om en ingrediens och dess mängd
    public class Ingredient
    {
        public string Name { get; set; }

        //mängden av ingrediensen (t.ex. "2 dl", "1 tsk")
        public string Measure { get; set; }
    }
}
