using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++){
                names[i] = Console.ReadLine();
            }  
            
            Console.WriteLine(names[0] + " är här, och " + names[1] + " är här, å så roligt att "+ names[2] +" är här. Och i vårt glada gänga har vi " + names[3] + " här igen, å så roligt att " + names[4] + " här...");
        }
    }
}
