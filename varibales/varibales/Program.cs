namespace varibales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine(num1*num2);

            string myName = "Danies";
            string message = "My name is"+ " " + myName;
            message.ToUpper();
            Console.WriteLine(message);
        }
    }
}