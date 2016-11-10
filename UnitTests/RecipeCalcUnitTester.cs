using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Collections.Generic;
using RecipeCalculator.Interfaces;
using RecipeCalculator;

namespace UnitTests
{
    [TestClass]
    public class RecipeCalcUnitTester
    {
        private static IEnumerable<IRecipe> Recipes;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            Recipes = new MockDataFeed().GetRecipes();
        }

        [TestMethod]
        public void TestRecipeTaxCalc()
        {
            decimal[] expectedTax = { 0.21m, 0.91m, 0.42m };

            Recipes.ForEachWithIndex((r, i) => Assert.IsTrue(r.GetTax() == expectedTax[i]));
        }

        [TestMethod]
        public void TestRecipeDiscountCalc()
        {
            decimal[] expectedDiscount = { 0.11m, 0.09m, 0.07m };

            Recipes.ForEachWithIndex((r, i) => Assert.IsTrue(r.GetDiscount() == expectedDiscount[i]));
        }

        [TestMethod]
        public void TestRecipeTotalCalc()
        {
            decimal[] expectedTotal = { 4.45m, 11.84m, 8.91m };

            Recipes.ForEachWithIndex((r, i) => Assert.IsTrue(r.GetTotal() == expectedTotal[i]));
        }
    }
}
