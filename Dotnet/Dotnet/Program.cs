namespace Dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter number not letter or specical carracters"); ;
            }
            Console.ReadKey();
        }
    }
}