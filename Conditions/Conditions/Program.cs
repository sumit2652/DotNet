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
            bool userEnteredANumber = int.TryParse(temp, out number);
            if(userEnteredANumber)
            {
                numTem = number;
            }
            else
            {
                number = 0;
                Console.WriteLine("Value entered, was no number or it was a text. 0 set as a temprtaure by default");
            }

            if(number < 18)
            {
                Console.WriteLine("take a jacket, it is below 20 dgree");
            }
            else if(number > 18) {
                Console.WriteLine("Take a jumper");
            }
            else if (number == 18)
            {
                Console.WriteLine("It is hot go for bike");
            }

            Console.Read();
        }
    }
}