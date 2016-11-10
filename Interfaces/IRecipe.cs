namespace RecipeCalculator.Interfaces
{
    public interface IRecipe
    {
        decimal GetSubTotal();
        decimal GetTax();
        decimal GetDiscount();
        decimal GetTotal();
    }
}
