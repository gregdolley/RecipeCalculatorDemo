using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeCalculator.DataObjects;

namespace RecipeCalculator.Interfaces
{
    public interface IDataFeed
    {
        IEnumerable<IRecipe> GetRecipes();
    }
}
