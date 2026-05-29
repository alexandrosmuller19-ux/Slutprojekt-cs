using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace drinks_info.Models
{
    public class Drinks
    {
        //wrapper-klass för deserialisering av drinkar från API-svar
        [JsonProperty("drinks")]
        public List<Drink> DrinksList { get; set; }
    }

    // Drink, Basklass för drinkar
    //customDrink ärver från denna klass
    public class Drink
    {

        public string idDrink { get; set; }

        public string strDrink { get; set; }

        //virtuell metod som kan överskrivas av subklasser för custom beteende
        //returnerar en kort beskrivning av drinken
        public virtual string GetDescription()
        {
            return $"Drink: {strDrink}";
        }

        public virtual string GetDetailsAsText()
        {
            return $"ID: {idDrink}\nName: {strDrink}";
        }

        public virtual bool IsValid()
        {
            return !string.IsNullOrEmpty(idDrink) && !string.IsNullOrEmpty(strDrink);
        }
    }
}
