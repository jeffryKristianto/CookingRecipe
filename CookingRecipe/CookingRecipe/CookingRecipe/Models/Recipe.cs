using Newtonsoft.Json;

namespace CookingRecipe.Models
{
    public class Recipe
    {        
        public string Publisher { get; set; }
        [JsonProperty("f2f_url")]
        public string F2fUrl { get; set; }
        public string Title { get; set; }
        [JsonProperty("source_url")]
        public string SourceUrl{ get; set; }
        [JsonProperty("recipe_id")]
        public string RecipeId { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        [JsonProperty("social_rank")]
        public double SocialRank { get; set; }
        [JsonProperty("publisher_url")]
        public string PublisherUrl { get; set; }
    }
}
