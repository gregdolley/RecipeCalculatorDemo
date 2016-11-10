namespace RecipeCalculator.Interfaces
{
    public interface IRecipeItem
    {
        IIngredient Item { get; }
        decimal Amount { get; }
    }
}
