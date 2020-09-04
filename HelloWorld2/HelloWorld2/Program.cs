using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld2
{
    class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();

            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++){
                
                names[i] = Console.ReadLine();
            }  
            
            Console.WriteLine(names[0] + " är här, och " + names[1] + " är här, å så roligt att "+ names[2] +" är här. Och i vårt glada gänga har vi " + names[3] + " här igen, å så roligt att " + names[4] + " här...");

            for (int name = 4; name >= 0; name--){
                Console.WriteLine(names[name]);
            }
            
            string[][] namesAge = new string[5][2];
        }
    }
}
