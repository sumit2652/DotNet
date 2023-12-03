using System.Threading.Channels;

namespace OOP_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car audi = new car();
            Console.WriteLine("Press 2 to stop the car");
            string userInput = Console.ReadLine();
            if (userInput == "1" ) {
                audi.Drive();
            }
            if (userInput == "2" )
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car will drive indefinetely");
            }
        }
    }
}