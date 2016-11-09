using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator
{
    public enum IngredientAttribute
    {
        Produce = 1,
        Organic = 2
    }

    public class Ingredient
    {
        public string Name { get; private set; }
        public double UnitCost { get; private set; }
        public IEnumerable<IngredientAttribute> Attributes { get; private set; }

        public Ingredient(string name, double unitCost, IEnumerable<IngredientAttribute> attributes)
        {
            Name = name;
            UnitCost = unitCost;
            Attributes = attributes;
        }
    }
}
