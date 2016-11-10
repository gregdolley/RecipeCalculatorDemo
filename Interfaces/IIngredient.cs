﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
