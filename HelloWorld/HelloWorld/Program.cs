using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 0;
            Console.WriteLine("Hallå där! Hur gammal är du?");
            while (true)
            {
                var input = Console.ReadLine();
                age = int.Parse(input);
                if(age < 130)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            
            Console.WriteLine("Vad heter du?");
            var name = Console.ReadLine();

            switch (name)
            {
                case "Johan":
                    Console.WriteLine("Hallå där Bohan");
                    break;
                case "Björn":
                    Console.WriteLine("Vet inte om ö funkar");
                    break;
                case "GW_Person":
                    Console.WriteLine("Jag gillar dig!");
                    break;
                default:
                    Console.WriteLine("Hallå där " + name);
                    break;

            }

            Console.WriteLine("Lever du? (No / Yes)");
            bool alive = false;
            if (Console.ReadLine().ToLower() == "yes") {
                alive = true;
            }

            Console.WriteLine("Du heter " + name + ", du är " + age + " år och du " );
            if (alive == true)
            {
                Console.WriteLine("lever.");
            }
            else
            {
                Console.WriteLine("lever inte.");
            }
            Console.WriteLine("Jag gillar jämna tal");
            for(int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
