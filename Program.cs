using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Ingredient> ingredients = new Dictionary<string, Ingredient>();

            ingredients.Add("garlic", new Ingredient("garlic", 0.67, new List<IngredientAttribute>() {IngredientAttribute.Produce, IngredientAttribute.Organic}));
            ingredients.Add("lemon", new Ingredient("lemon", 2.03, new List<IngredientAttribute>() {IngredientAttribute.Produce}));
            ingredients.Add("corn", new Ingredient("corn",0.87, new List<IngredientAttribute>() {IngredientAttribute.Produce}));
            ingredients.Add("chicken", new Ingredient("chicken",2.19, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("bacon", new Ingredient("bacon",0.24, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("pasta", new Ingredient("pasta",0.31, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("olive oil", new Ingredient("olive oil",1.92, new List<IngredientAttribute>() {IngredientAttribute.Organic}));
            ingredients.Add("vinegar", new Ingredient("vinegar",1.26, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("salt", new Ingredient("salt",0.16, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("pepper", new Ingredient("pepper",0.17, Enumerable.Empty<IngredientAttribute>()));

            List<Recipe> recipesList = new List<Recipe>();
            
            recipesList.Add(new Recipe(new List<RecipeItem>() {new RecipeItem(ingredients["garlic"], 1),
                                                               new RecipeItem(ingredients["lemon"], 1),
                                                               new RecipeItem(ingredients["olive oil"], 0.75),
                                                               new RecipeItem(ingredients["salt"], 0.75),
                                                               new RecipeItem(ingredients["pepper"], 0.5)}));

            recipesList.Add(new Recipe(new List<RecipeItem>() {new RecipeItem(ingredients["garlic"], 1),
                                                               new RecipeItem(ingredients["chicken"], 4),
                                                               new RecipeItem(ingredients["olive oil"], 0.5),
                                                               new RecipeItem(ingredients["vinegar"], 0.5)}));

            recipesList.Add(new Recipe(new List<RecipeItem>() {new RecipeItem(ingredients["garlic"], 1),
                                                               new RecipeItem(ingredients["corn"], 4),
                                                               new RecipeItem(ingredients["bacon"], 4),
                                                               new RecipeItem(ingredients["pasta"], 8),
                                                               new RecipeItem(ingredients["olive oil"], 0.333333),
                                                               new RecipeItem(ingredients["salt"], 1.25),
                                                               new RecipeItem(ingredients["pepper"], 0.75)}));

            recipesList.ForEachWithIndex((recipe, index) =>
            {
                Console.WriteLine(string.Format("Recipe {0}", index + 1));
                Console.WriteLine();
                Console.WriteLine(string.Format("\tTax = {0:C}", recipe.GetTax()));
                Console.WriteLine(string.Format("\tDiscount = {0:C}", -recipe.GetDiscount()));
                Console.WriteLine(string.Format("\tTotal = {0:C}", recipe.GetTotal()));
                Console.WriteLine();
            });

            Console.ReadKey();
        }
    }
}
