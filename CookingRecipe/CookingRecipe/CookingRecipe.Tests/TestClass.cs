using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookingRecipe.Services;

namespace CookingRecipe.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            IRecipeService service = new RecipeService();
            var result = service.GetRecipes("Sushi").Result;

            Assert.AreEqual(true, true);
        }
    }
}
