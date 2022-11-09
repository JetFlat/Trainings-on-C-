using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Please, enter your role");
            string role = Console.ReadLine();

            if (role == "Admin")
            {
                Console.WriteLine("Please enter Admin password to get into Admin settings");
                string password = Console.ReadLine();

                do
                {
                    Console.WriteLine("Please, try again");
                }
                while (password.Length < 8);

            }

            else
            {
                Console.WriteLine("You entered as a Guest ");
            }
        }   
    }
}


