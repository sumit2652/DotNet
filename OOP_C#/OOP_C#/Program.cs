using System.Threading.Channels;

namespace OOP_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car audi = new car("Audi A7", 250, "Red");
            audi.Drive();
            audi.Details();
            car bmw = new car("Bmw M5" , 350 );
            bmw.Drive();
            bmw.Details();

            Console.WriteLine("Press 2 to stop the car");
            string userInput = Console.ReadLine();

            if (userInput == "2" )
            {
                audi.Stop();
                bmw.Stop();
            }
            else
            {
                Console.WriteLine($"{audi} and {bmw} will drive indefinitely.");
            }
        }
     
    }
}