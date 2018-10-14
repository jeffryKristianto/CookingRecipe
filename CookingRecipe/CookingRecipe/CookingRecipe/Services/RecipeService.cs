using System;
using System.Net.Http;
using System.Threading.Tasks;
using CookingRecipe.Models;

namespace CookingRecipe.Services
{
    public class RecipeService : HttpService, IRecipeService
    {
        private static readonly string BASE_URI = "https://food2fork.com/api";
        private static readonly string API_KEY = ""; // TODO: Add API Key

        public async Task<RecipeList> GetRecipes(string query)
        {
            Uri url = new Uri(BASE_URI + $"/search?key={API_KEY}&q={query}");
            var response = await SendRequestAsync<RecipeList>(url, HttpMethod.Get);

            return response;
        }
    }
}