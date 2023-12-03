namespace nested_condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool admin = false;
            bool isRegistred = true;
            string userName = "";
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();
            
            if (isRegistred )
            {
                Console.WriteLine("Hi there, registred user");
                if (userName != "") {
                    Console.WriteLine("Hi there," + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi There admin");
                    }
                }
            }

            // anthor way of nested conditions

            if (isRegistred && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registred user");
                Console.WriteLine("Hi there," + userName);
                Console.WriteLine("Hi There admin");
            }
            if (admin || isRegistred)
            {
                Console.WriteLine("You are looged in");
            }
            Console.ReadLine();
        }
    }
}