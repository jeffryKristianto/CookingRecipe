using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRecipe.Models
{
    public class RecipeList
    {
        public int Count { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
