using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeCalculator.Common;
using RecipeCalculator.Interfaces;

namespace RecipeCalculator.DataObjects
{
    public class Ingredient : IIngredient
    {
        public string Name { get; private set; }
        public decimal UnitCost { get; private set; }
        public IEnumerable<IngredientAttribute> Attributes { get; private set; }

        public Ingredient(string name, decimal unitCost, IEnumerable<IngredientAttribute> attributes)
        {
            Name = name;
            UnitCost = unitCost;
            Attributes = attributes;
        }
    }
}
