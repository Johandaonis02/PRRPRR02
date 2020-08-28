using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 0;
            Console.WriteLine("Hallå där! Hur gammal är du?");
            var input = Console.ReadLine();
            age = int.Parse(input);
            Console.WriteLine("Vad heter du?");
            var name = Console.ReadLine();
            Console.WriteLine("Lever du? (No / Yes)");
            bool alive = false;
            if (Console.ReadLine().ToLower() == "yes") {
                alive = true;
            }

            Console.WriteLine("Du heter " + name + ", du är " + age + " år och du " );
            if (alive == true) {
                Console.WriteLine("lever.");
            }
            else {
                Console.WriteLine("lever inte.");
            }
            Console.ReadLine();
        }
    }
}
