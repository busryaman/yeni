using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hi");
        Console.WriteLine("choose what do you want (as number)");
        Console.WriteLine("1- sign in");
        Console.WriteLine("2- sign up");
        int preference1=int.Parse(Console.ReadLine());
        switch (preference1)
        { case 1:
            Console.WriteLine("enter your username ");
            string username= Console.ReadLine();
            Console.WriteLine("enter your password");
            string password = Console.ReadLine();
            break;
        }
    }
}