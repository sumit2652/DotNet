using System.Threading.Channels;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temprature like?");
            string temp = Console.ReadLine();
            int numTem;
            int number;
            if(int.TryParse(temp, out numTem))
            {
                number = numTem;
            }
            else
            {
                number = 0;
                Console.WriteLine("Value entered, was no number or it was a text. 0 set as a temprtaure by default");
            }

            if(numTem < 18)
            {
                Console.WriteLine("take a jacket, it is below 20 dgree");
            }
            else if(numTem > 18) {
                Console.WriteLine("Take a jumper");
            }
            else if (numTem == 18)
            {
                Console.WriteLine("It is hot go for bike");
            }

            Console.Read();
        }
    }
}