using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
