using System.Collections.Generic;

namespace RecipeCalculator.Interfaces
{
    public interface IDataFeed
    {
        IEnumerable<IRecipe> GetRecipes();
    }
}
