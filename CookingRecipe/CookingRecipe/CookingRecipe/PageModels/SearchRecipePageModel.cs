using System.Collections.ObjectModel;
using System.Threading.Tasks;

using FreshMvvm;

using CookingRecipe.Models;
using CookingRecipe.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace CookingRecipe.ViewModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class SearchRecipePageModel : FreshBasePageModel
    {
        private IRecipeService _recipeService;

        public bool IsBusy { get; set; }

        public ObservableCollection<Recipe> Recipes { get; set; }

        public SearchRecipePageModel(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        private ICommand _searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                return _searchCommand ?? (_searchCommand = new Command<string>(async (text) =>
                {
                    await Search(text);
                }));
            }
        }

        private async Task Search(string query)
        {
            IsBusy = true;
            try
            {
                var list = await _recipeService.GetRecipes(query);
                Recipes = new ObservableCollection<Recipe>(list.Recipes);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}