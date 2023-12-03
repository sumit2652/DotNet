using System.Threading.Channels;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temprature like?");
            string temp = Console.ReadLine();
            int numTem = int.Parse(temp);

            if(numTem < 18)
            {
                Console.WriteLine("take a jacket, it is below 20 dgree");
            }
            if(numTem > 18) {
                Console.WriteLine("Take a jumper");
            }
            if (numTem == 18)
            {
                Console.WriteLine("It is hot go for bike");
            }

            Console.Read();
        }
    }
}