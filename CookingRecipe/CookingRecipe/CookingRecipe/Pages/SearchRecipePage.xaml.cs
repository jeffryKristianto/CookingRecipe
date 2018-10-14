using CookingRecipe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookingRecipe.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchRecipePage : ContentPage
    {
        public SearchRecipePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}