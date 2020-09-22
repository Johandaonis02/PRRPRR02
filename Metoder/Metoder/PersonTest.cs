using System;
using System.Collections.Generic;
using System.Text;

namespace Metoder
{
    class PersonTest
    {
        public string _name;
        public int _age;
        public double _height;

        public AnimalTest _pet;

        public void Move()
        {
            Console.WriteLine(_name + " is moving!");
        }
        public void Eat()
        {
            Console.WriteLine(_name + " is eating!");
        }
        public void Communicate()
        {
            Console.WriteLine(_name + ": hallo there. Jag är " + _age);
        }
    }
}
