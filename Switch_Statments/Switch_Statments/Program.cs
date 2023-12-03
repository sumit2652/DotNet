namespace Switch_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 15;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young for party in the club");
                    break;
                case 25:
                    Console.WriteLine("you can join club");
                    break;
                default: Console.WriteLine("How old are you?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young for party");
            }
            else if (age == 25)
            {
                Console.WriteLine("You can join cloub");
            }
            else { Console.WriteLine("What is your age");
            }
            Console.Read();
        }
    }
}