using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCalculator
{
    public static class ExtensionMethods
    {
        public static decimal RoundUpToNearest(this decimal inputNumber, decimal roundTo)
        {
            return roundTo == 0 ? inputNumber : Math.Ceiling(inputNumber / roundTo) * roundTo;
        }

        public static void ForEachWithIndex<T>(this IEnumerable<T> items, Action<T, int> action)
        {
            int c = 0;

            foreach (T item in items)
                action(item, c++);
        }
    }
}
