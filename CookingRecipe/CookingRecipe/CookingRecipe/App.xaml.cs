using CookingRecipe.Pages;
using CookingRecipe.Services;
using CookingRecipe.ViewModels;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CookingRecipe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FreshIOC.Container.Register<IRecipeService, RecipeService>();

            var page = FreshPageModelResolver.ResolvePageModel<SearchRecipePageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);

            MainPage = basicNavContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
