using CookingRecipe.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipe.Services
{
    public interface IRecipeService
    {
        Task<RecipeList> GetRecipes(string query);
    }
}
