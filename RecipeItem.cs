using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator
{
    public class RecipeItem
    {
        public Ingredient Item { get; private set; }
        public double Amount { get; private set; } // amount of the ingredient (ex: 3/4 cup of olive oil = 0.75)

        public RecipeItem(Ingredient item, double amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}
