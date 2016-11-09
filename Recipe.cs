using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator
{
    public class Recipe
    {
        private IEnumerable<RecipeItem> Items;

        public Recipe(IEnumerable<RecipeItem> items)
        {
            Items = items;
        }

        public double GetSubTotal()
        {
            return Items.Sum(n => n.Amount * n.Item.UnitCost);
        }

        public double GetTax()
        {
            //IEnumerable<RecipeItem> taxableItems = Items.Where(n => !n.Item.Attributes.Contains(IngredientAttribute.Produce));
            //double totalUnitCost = taxableItems.Sum(n => n.Amount * n.Item.UnitCost);
            //return (totalUnitCost * 0.086).RoundUpToNearest(0.07);

            return (Items.Where(n => !n.Item.Attributes.Contains(IngredientAttribute.Produce))
                         .Sum(n => n.Amount * n.Item.UnitCost) * 0.086).RoundUpToNearest(0.07);

        }

        public double GetDiscount()
        {
            return (Items.Where(n => n.Item.Attributes.Contains(IngredientAttribute.Organic))
                         .Sum(n => n.Amount * n.Item.UnitCost) * 0.05).RoundUpToNearest(0.01);
        }

        public double GetTotal()
        {
            return (GetSubTotal() + GetTax() - GetDiscount());
        }
    }
}
