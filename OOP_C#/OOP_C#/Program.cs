using System.Threading.Channels;

namespace OOP_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car audi = new car("Audo A7");
            audi.Drive();
            car bmw = new car("Bmw M5");
            bmw.Drive();

            Console.WriteLine("Press 2 to stop the car");
            string userInput = Console.ReadLine();

            if (userInput == "2" )
            {
                audi.Stop();
                bmw.Stop();
            }
            else
            {
                Console.WriteLine("Car will drive indefinetely");
            }
        }
    }
}