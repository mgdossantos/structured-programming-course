using System;

class Program { 
    static void Main(string[] args)
    {
        int number;

        Console.WriteLine("Type a number: ");
        number = int.Parse(Console.ReadLine());
        while (number!=-1)
        {
           

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine("Type a number: ");
            number = int.Parse(Console.ReadLine());



        }

    }
}