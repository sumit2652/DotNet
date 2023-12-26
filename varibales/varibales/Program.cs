namespace varibales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine(num1*num2);

            string myName = "danies";
            string message = "My name is"+ " " + myName;
            string capMessage = message.ToUpper();
            Console.WriteLine(capMessage);
        }
    }
}