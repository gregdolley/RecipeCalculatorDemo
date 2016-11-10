using RecipeCalculator.Interfaces;

namespace RecipeCalculator.DataObjects
{
    public class RecipeItem : IRecipeItem
    {
        public IIngredient Item { get; private set; }
        public decimal Amount { get; private set; } // amount of the ingredient (ex: 3/4 cup of olive oil = 0.75)

        public RecipeItem(IIngredient item, decimal amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}
