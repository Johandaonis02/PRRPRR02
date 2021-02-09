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
            Console.WriteLine("Den kostar " + result + " kr");
        }
    }
}