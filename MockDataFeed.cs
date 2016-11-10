using System.Collections.Generic;
using System.Linq;
using RecipeCalculator.Interfaces;
using RecipeCalculator.DataObjects;
using RecipeCalculator.Common;

namespace RecipeCalculator
{
    public class MockDataFeed : IDataFeed
    {
        private ICollection<IRecipe> RecipesList = new List<IRecipe>();

        public MockDataFeed()
        {
            //-----------------------------------------------------------------------------------------------------------
            // Normally, all these data objects would be filled in from the database through a repo/unit of work pattern,
            // but I don't want this demo to require a LocalDB schema/data import just to run on another machine.
            //-----------------------------------------------------------------------------------------------------------
            Dictionary<string, IIngredient> ingredients = new Dictionary<string, IIngredient>();

            ingredients.Add("garlic",    new Ingredient("garlic",    0.67m, new List<IngredientAttribute>() { IngredientAttribute.Produce, IngredientAttribute.Organic }));
            ingredients.Add("lemon",     new Ingredient("lemon",     2.03m, new List<IngredientAttribute>() { IngredientAttribute.Produce }));
            ingredients.Add("corn",      new Ingredient("corn",      0.87m, new List<IngredientAttribute>() { IngredientAttribute.Produce }));
            ingredients.Add("chicken",   new Ingredient("chicken",   2.19m, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("bacon",     new Ingredient("bacon",     0.24m, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("pasta",     new Ingredient("pasta",     0.31m, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("olive oil", new Ingredient("olive oil", 1.92m, new List<IngredientAttribute>() { IngredientAttribute.Organic }));
            ingredients.Add("vinegar",   new Ingredient("vinegar",   1.26m, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("salt",      new Ingredient("salt",      0.16m, Enumerable.Empty<IngredientAttribute>()));
            ingredients.Add("pepper",    new Ingredient("pepper",    0.17m, Enumerable.Empty<IngredientAttribute>()));

            RecipesList.Add(new Recipe(new List<RecipeItem>() {new RecipeItem(ingredients["garlic"],    1),
                                                               new RecipeItem(ingredients["lemon"],     1),
                                                               new RecipeItem(ingredients["olive oil"], 0.75m),
                                                               new RecipeItem(ingredients["salt"],      0.75m),
                                                               new RecipeItem(ingredients["pepper"],    0.5m)}));

            RecipesList.Add(new Recipe(new List<RecipeItem>() {new RecipeItem(ingredients["garlic"],    1),
                                                               new RecipeItem(ingredients["chicken"],   4),
                                                               new RecipeItem(ingredients["olive oil"], 0.5m),
                                                               new RecipeItem(ingredients["vinegar"],   0.5m)}));

            RecipesList.Add(new Recipe(new List<RecipeItem>() {new RecipeItem(ingredients["garlic"],    1),
                                                               new RecipeItem(ingredients["corn"],      4),
                                                               new RecipeItem(ingredients["bacon"],     4),
                                                               new RecipeItem(ingredients["pasta"],     8),
                                                               new RecipeItem(ingredients["olive oil"], 0.333333m),
                                                               new RecipeItem(ingredients["salt"],      1.25m),
                                                               new RecipeItem(ingredients["pepper"],    0.75m)}));
        }

        public IEnumerable<IRecipe> GetRecipes()
        {
            return (RecipesList);
        }
    }
}
