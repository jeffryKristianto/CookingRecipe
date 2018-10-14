using System;
using System.Net.Http;
using System.Threading.Tasks;
using CookingRecipe.Models;

namespace CookingRecipe.Services
{
    public class RecipeService : HttpService, IRecipeService
    {
        private static readonly string BASE_URI = "https://food2fork.com/api";
        

        public async Task<RecipeList> GetRecipes(string query)
        {
            Uri url = new Uri(
                BASE_URI + $"/search?key={CookingRecipe.Configs.ApiKey.API_KEY}&q={query}");  // TODO: Add API Key
            var response = await SendRequestAsync<RecipeList>(url, HttpMethod.Get);

            return response;
        }
    }
}