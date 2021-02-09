using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class MonkeyCost : ICost
    {
        public void Calculate(int numberOfArms,int numberOfLegs)
        {
            var result = Math.Pow(numberOfArms, numberOfLegs);
            Console.WriteLine("Den kostar " + result + " kr");
        }
    }
}