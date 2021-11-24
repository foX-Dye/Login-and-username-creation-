using System;

namespace Login_menu
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
        }
        public static void Register()
        {
            Console.WriteLine("Please create a username.");
            username = Console.ReadLine();
            Console.WriteLine("Please create a password.");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed!");
            Console.WriteLine("_-_-_-_-_-_- _ - _ - _ - _ - _ - _ - _ - _ - _ - _ - _ - _ -");
        }
        public static void Login()
        {
            Console.WriteLine("please enter your username.");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password.");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Please restart the program.");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Please restart the program.");
            }
        }
    }
}
