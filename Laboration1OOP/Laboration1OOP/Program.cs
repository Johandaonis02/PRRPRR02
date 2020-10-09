using System;
using System.Runtime.InteropServices;

namespace Laboration1OOP{
    class Program{
        static void Main(string[] args){
            var rand = new Random();

            Console.WriteLine("Skriv ja om du vill skapa en ny customer");
            while (true){
                if(Console.ReadLine() == "ja"){
                    break;
                }
            }

            Customer customer = new Customer();
            customer._age = rand.Next(30);
            
            while (true){
                Console.WriteLine("Skriv ja om du vill skapa en ny customer")
            }

            Product product1 = new Product();
            product1._name = "snus";
            
            if (product1._name == "snus"){
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

            
        }
    }
}
