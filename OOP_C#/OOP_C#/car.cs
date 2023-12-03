using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_C_
{
    internal class car
    {
        private string _name;
        private int _hp;
        private string _colour;
 
        public car(string name, int hp = 0, string colour = "Black") 
        {
            _name = name;
            Console.WriteLine(name + "Car was created");
            _hp = hp;
            _colour = colour;
        }

        public void Drive ()
        {
            Console.WriteLine(_name + "Car is driving");
        }

        public void Stop()
        {
            Console.WriteLine(_name + "Car is stopped");
        }
        public void Details()
        {
            Console.WriteLine($"The {_colour} car {_name} has {_hp} hp");
        }


    }
}
