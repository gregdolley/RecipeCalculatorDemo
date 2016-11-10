using System.Collections.Generic;
using RecipeCalculator.Common;

namespace RecipeCalculator.Interfaces
{
    public interface IIngredient
    {
        string Name { get; }
        decimal UnitCost { get; }
        IEnumerable<IngredientAttribute> Attributes { get; }
    }
}
