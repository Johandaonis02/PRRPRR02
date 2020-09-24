using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration1OOP {
    class Customer {
        public string _name;
        public int _age;

        public void WantToBuyStuff() {
            Console.WriteLine("Hej, jag heter " + _name + " och jag vill köpa produkter");
        }

        public void TellAge() {
            Console.WriteLine("Jag är " + _age + " år");
        }
    }
}
