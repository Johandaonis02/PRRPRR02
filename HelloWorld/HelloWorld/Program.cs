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
                if(age > 130){
                    Console.WriteLine("no");
                }
                else{
                    break;
                }
            }
            Console.WriteLine("Vad heter du?");
            var name = Console.ReadLine();
            Console.WriteLine("Lever du? (No / Yes)");
            bool alive = false;
            if (Console.ReadLine().ToLower() == "yes") {
                alive = true;
            }
            else if(Console.ReadLine().ToLower() != "no"){
                Console.WriteLine("No? Ok")
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
            for (int i = 0; i < 10; i += 2){
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
