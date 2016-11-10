using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator.Interfaces
{
    public interface IRecipeItem
    {
        IIngredient Item { get; }
        decimal Amount { get; }
    }
}
