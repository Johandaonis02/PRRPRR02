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

                while (true){
                    Console.WriteLine("Skriv 1 om du vill köpa en banan, skriv 2 om du vill köpa snus, skriv klar när du är klar");
                    String WhatCustomerWant = Console.ReadLine();

                    Product product1 = new Product();
                    if (WhatCustomerWant == "klar"){
                        break;
                    }
                    else if (WhatCustomerWant == "1"){
                        product1._name = "banan";
                    }
                    else if (WhatCustomerWant == "2"){
                        product1._name = "snus";
                    }
                    else{
                        product1._name = "glass";
                        Console.WriteLine("Vi har inte den produkten men här får du glass");
                    }

                    if (product1._name == "snus"){
                        product1._ageLimit = 18;
                    }

                    if (product1._ageLimit <= customer._age){
                        Console.WriteLine(product1._name + ", du får köpa denna producten");
                        customer._cart.Add(product1);
                    }
                    else{
                        Console.WriteLine(product1._name + ", du får inte köpa denna producten");
                    }
                }
            }
        }
    }
}
