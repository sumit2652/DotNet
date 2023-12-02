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
            catch(FormatException)
            {
                Console.WriteLine("Please enter number not letter or specical carracters");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow expectionm");
            }
            Console.ReadKey();
        }
    }
}