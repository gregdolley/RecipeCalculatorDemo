using System;
using System.Collections.Generic;
using RecipeCalculator.Interfaces;

namespace RecipeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IRecipe> recipesList = new MockDataFeed().GetRecipes();

            recipesList.ForEachWithIndex((recipe, index) =>
            {
                Console.WriteLine(string.Format("Recipe {0}", index + 1));
                Console.WriteLine();
                Console.WriteLine(string.Format("\tTax = {0:C}", recipe.GetTax()));
                Console.WriteLine(string.Format("\tDiscount = {0:C}", -recipe.GetDiscount()));
                Console.WriteLine(string.Format("\tTotal = {0:C}", recipe.GetTotal()));
                Console.WriteLine();
            });

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
