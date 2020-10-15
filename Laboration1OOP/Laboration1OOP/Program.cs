using System;
using System.Runtime.InteropServices;

namespace Laboration1OOP{
    class Program{
        static void Main(string[] args){
            var rand = new Random();

            while (true){
                Console.WriteLine("Skriv ja om du vill skapa en ny customer");
                while (true){
                    if (Console.ReadLine() == "ja"){
                        break;
                    }
                }

                Customer customer = new Customer();
                customer._age = rand.Next(30);

                while (true)
                {
                    Console.WriteLine("Skriv 1 om du vill köpa en banan, 2 för snus, klar för klar eller så kan du skriva vad du vill för att se om det finns");
                    String WhatCustomerWant = Console.ReadLine();


                    Product product1 = new Product();

                    if (WhatCustomerWant == "klar")
                    {
                        break;
                    }
                    else if (WhatCustomerWant == "1")
                    {
                        product1._name = "banan";
                    }
                    else if (WhatCustomerWant == "2")
                    {
                        product1._name = "snus";
                    }
                    else
                    {
                        product1._name = "glass";
                        Console.WriteLine("Vi har inte den produkten men här får du glass");
                    }

                    if (product1._name == "snus")
                    {
                        product1._ageLimit = 18;
                    }

                    if (product1._ageLimit <= customer._age)
                    {
                        Console.WriteLine(product1._name + ", du får köpa denna producten");
                        customer._cart.Add(product1);
                    }
                    else
                    {
                        Console.WriteLine(product1._name + ", du får inte köpa denna producten");
                    }

                    Console.WriteLine("Vill du också ha ett djur?");
                    if (Console.ReadLine() == "Ja"){
                        Animal product2 = new Animal();

                        Console.WriteLine("Hur gulligt ska djuret vara?");
                        product2._cuteness = Convert.ToInt32(Console.ReadLine());

                        if(product2._cuteness < 10){
                            product1._name = "katt";
                            Console.WriteLine("Då får du en katt");
                        }
                        else if (product2._cuteness < 100){
                            product1._name = "hund";
                            Console.WriteLine("Då får du en hund");
                        }
                        else{
                            Console.WriteLine("Det är för gulligt");
                        }
                    }

                    Console.WriteLine("Vill du också ha en bil?");
                    if (Console.ReadLine() == "Ja")
                    {
                        Car product3 = new Car();

                        Console.WriteLine("Hur mycket ska bilen väga?");
                        product3._weight = Convert.ToInt32(Console.ReadLine());

                        if (product3._weight < 1000){
                            product3._name = "bil1";
                            Console.WriteLine("Då får du bil1");
                        }
                        else if (product3._weight < 2000){
                            product3._name = "bil2";
                            Console.WriteLine("Då får du bil2");
                        }
                        else{
                            Console.WriteLine("Den väger för mycket.");
                        }
                    }
                }
            }
        }
    }
}
