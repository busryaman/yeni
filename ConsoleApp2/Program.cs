using System;

class Program
{
    static void Main(string[] args)
    {
        string username = "";
        string password = "";
        double balance = 0;
        double operation = 0;
        Console.WriteLine("hi");
        Console.WriteLine("choose what do you want (as number)");
        Console.WriteLine("1- sign in");
        Console.WriteLine("2- sign up");
        Console.WriteLine("3- exit");
        int preference1 = int.Parse(Console.ReadLine());
        while (preference1 != 3)
        {


            switch (preference1)
            {
                case 1:
                    Console.WriteLine("enter your username ");
                    username = Console.ReadLine();
                    Console.WriteLine("enter your password");
                    password = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("create an account");
                    Console.WriteLine("decide a username");
                    username = Console.ReadLine();
                    Console.WriteLine("decide a password");
                    password = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("see ya later");
                    break;
                
                default:
                    Console.WriteLine("invalid");
                    break;
            }

            Console.WriteLine($"welcome {username}, please select the section");
            Console.WriteLine("\n 1-Make a deposit \n 2-Make a withdrawal " +
                              "\n 3-Check balance ");
            int preference2 = int.Parse(Console.ReadLine());
            switch (preference2)
            {
                case 1:
                    Console.WriteLine("how much you want to deposite");
                    operation = double.Parse(Console.ReadLine());
                    operation += balance;
                    break;
                case 2:
                    Console.WriteLine("how much you want to withfraw");
                    operation = double.Parse(Console.ReadLine());
                    operation -= balance;
                    break;
                case 3:
                    Console.WriteLine($"your balance is{balance}");
                    break;
            }
        }
    }
}