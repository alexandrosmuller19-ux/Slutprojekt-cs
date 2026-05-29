using System.Collections.Generic;
using Newtonsoft.Json;

namespace drinks_info.Models
{
    public class Category
    {
        //namnet på drinkkategorin från CocktailDB API
        public string strCategory { get; set; }
    }

    public class Categories
    {
        //wrapper-klass för deserialisering av kategorilistan från API-svaret
        [JsonProperty("drinks")]
        public List<Category> CategoriesList { get; set; }
    }
}