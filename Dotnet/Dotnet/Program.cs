namespace Dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            num3 = -num1;

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", isSunny);

            Console.WriteLine("num3 is {0},", num3);
            

            //increament in operators

            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", num++);

            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0} ", isLower);
   
            bool isEqaul;
            isEqaul = num1 == num2;
            Console.WriteLine("if results are equal {0}", isEqaul);
            Console.ReadLine();
        }
    }
}