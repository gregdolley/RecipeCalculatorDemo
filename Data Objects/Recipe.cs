using System;
using System.Collections.Generic;
using System.Linq;
using RecipeCalculator.Common;
using RecipeCalculator.Interfaces;

namespace RecipeCalculator.DataObjects
{
    public class Recipe : IRecipe
    {
        private IEnumerable<IRecipeItem> Items;

        public Recipe(IEnumerable<IRecipeItem> items)
        {
            Items = items;
        }

        public decimal GetSubTotal()
        {
            return Math.Round(Items.Sum(n => n.Amount * n.Item.UnitCost), 2, MidpointRounding.AwayFromZero);
        }

        public decimal GetTax()
        {
            return (Items.Where(n => !n.Item.Attributes.Contains(IngredientAttribute.Produce))
                         .Sum(n => n.Amount * n.Item.UnitCost) * 0.086m).RoundUpToNearest(0.07m);

        }

        public decimal GetDiscount()
        {
            return (Items.Where(n => n.Item.Attributes.Contains(IngredientAttribute.Organic))
                         .Sum(n => n.Amount * n.Item.UnitCost) * 0.05m).RoundUpToNearest(0.01m);
        }

        public decimal GetTotal()
        {
            return (GetSubTotal() + GetTax() - GetDiscount());
        }
    }
}
