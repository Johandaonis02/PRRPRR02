using StrategyPatternDemo.Strategy;
using System;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket djur vill du köpa? (Katt, hund, apa)");
            string animal = Console.ReadLine().ToLower();

         //   ICalculationStrategy strat;

            Console.WriteLine("Hur många armar ska den ha?");
            int numberOfArms;
            numberOfArms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur många ben ska den ha?");
            int numberOfLegs;
            numberOfLegs = Convert.ToInt32(Console.ReadLine());

            switch (animal)
            {
                case "katt":
                    cost = new CatCost();
                    break;
                case "hund":
                    cost = new DogCost();
                    break;
                case "apa":
                    cost = new MonkeyCost();
                    break;
                default:
                    Console.WriteLine("Error");
                    //strat = new AdditionStrategy();
                    break;
            }

            var calc = new Calculation(cost);
            calc.CalculationInterface(numberOne, numberTwo);
        }
    }
}