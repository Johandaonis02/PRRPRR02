using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration1OOP {
    class Product {
        public string _name;
        public int _ageLimit;
        public int _amount;

        public bool BuyProduct(string ProductName, int CustomerAge) {
            if(_ageLimit <= CustomerAge) {
                Console.WriteLine(_name + ", du får köpa denna producten");
                return true;
            }
            else {
                Console.WriteLine(_name + ", du får inte köpa denna producten");
                return false;
            }
        }
        public void Amount() {
            Console.WriteLine(_name + ", hur många vill du köpa?");
            var amount = Console.ReadLine();
            if(amount == int){

            }

            _amount
        }
    }
}
