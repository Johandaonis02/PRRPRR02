using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args){


            PersonTest niklas = new PersonTest();

            niklas._name = "Niklas";
            niklas._age = 200;
            niklas._height = 187;

            AnimalTest pet = new AnimalTest();

            pet._name = "Smulan";
            pet._species = "Kattmisse";

            niklas._pet = pet;

            niklas.Move();
            niklas.Eat();
            niklas.Communicate();

            Console.WriteLine(niklas._pet._name);


            Console.WriteLine("Hello World!");
            int number1 = 10;
            int number2 = 23;
            Console.WriteLine(Add(number1, number2));

            string[] words = {"hej","jag","heter","Johan"};
            WriteOutReverseOfList(words);

            int[] numbers = {3,5,6,9,23,72,4,-15};
            Console.WriteLine(FindsSmallestAndBiggestNumberInList(numbers));
            Console.ReadLine();
        }

        static int Add(int num1, int num2){
            return (num1 + num2);
        }

        static void WriteOutReverseOfList(string[] words){
            for (int i = words.Length - 1; i >= 0; i--) {
                Console.WriteLine(words[i]);
            }
        }

        static string FindsSmallestAndBiggestNumberInList(int[] numbers)
        {
            int biggest = numbers[0];
            int smallest = numbers[0];
            for (int i = 1; i < numbers.Length; i++){
                if (biggest < numbers[i])
                {
                    biggest = numbers[i];
                }
                else if (smallest > numbers[i])
                {
                    smallest = numbers[i];
                }
            }
            return ("Minsta talet är " + smallest + " och största talet är " + biggest);
        }


    }
}
