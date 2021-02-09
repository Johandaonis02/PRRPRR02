
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    class Cost
    {
        private ICost _strategy;

        public Cost(ICost strategy)
        {
            _strategy = strategy;
        }

        public void CalculationInterface(int num1, int num2)
        {
            _strategy.Calculate(num1, num2);
        }

        public static int AttractivePrice(double oldPrice)
        {
            double newPrice;

            double orderOfMagnitude = Math.Pow(10, (int)(Math.Log10(oldPrice)));

            newPrice = orderOfMagnitude * Math.Round( oldPrice / orderOfMagnitude);

            //Console.WriteLine(oldPrice + " " + newPrice + " " + orderOfMagnitude);

            return (int)newPrice - 1;
        }
    }
}