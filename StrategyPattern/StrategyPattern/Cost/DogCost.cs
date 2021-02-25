using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class DogCost : ICost
    {
        public void Calculate(int numberOfArms, int numberOfLegs)
        {
            var result = 5 * numberOfArms * numberOfLegs;

            result = Cost.AttractivePrice((double)result);

            Console.WriteLine("Den kostar " + result + " kr");
        }
    }
}