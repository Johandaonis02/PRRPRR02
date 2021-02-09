using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class CatCost : ICost
    {
        public void Calculate(int numberOfArms, int numberOfLegs)
        {
            var result = 20 * numberOfArms + 5 * numberOfLegs;


            Console.WriteLine("Test");
            result = Cost.AttractivePrice((double) result);

            Console.WriteLine("Den kostar " + result + " kr");
        }
    }
}