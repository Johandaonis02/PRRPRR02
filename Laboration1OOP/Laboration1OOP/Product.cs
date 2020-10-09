using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration1OOP {
    class Product {
        public string _name;
        public int _ageLimit;
        public int _amount;

        public void Amount() {
            Console.WriteLine(_name + ", hur många vill du köpa?");
            var amount = Console.ReadLine();

        }
    }
}
