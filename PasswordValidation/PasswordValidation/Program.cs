using System;

class Program
{
    static void Main(String[] args)
    {
        string password="marceladossantos";
        string guess;
        do
        {
            Console.WriteLine("Password: ");
            guess= Console.ReadLine();


        }
        while (password!=guess);

        Console.WriteLine("Login!!!");

    }
}

