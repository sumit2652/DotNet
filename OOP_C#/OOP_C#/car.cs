using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_C_
{
    internal class car
    {
        public car() 
        { 
            Console.WriteLine("Car was created"); 
        }

        public void Drive ()
        {
            Console.WriteLine("Car is driving");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopped");
        }


    }
}
