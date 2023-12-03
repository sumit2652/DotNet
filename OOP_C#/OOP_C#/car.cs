using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_C_
{
    internal class car
    {
        private string _name;
 
        public car(string name) 
        {
            _name = name;
            Console.WriteLine(name + "Car was created"); 
        }

        public void Drive ()
        {
            Console.WriteLine(_name + "Car is driving");
        }

        public void Stop()
        {
            Console.WriteLine(_name + "Car is stopped");
        }


    }
}
