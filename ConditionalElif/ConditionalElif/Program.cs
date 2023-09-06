using System;

class Program
{
    static void Main(string[] args)
    {
        float A;

        Console.WriteLine("Type a number: ");
        A = float.Parse(Console.ReadLine());

        if (A > 0)
        {
            Console.WriteLine("You typed a number greater than 0!");
        }
        else if (A == 0)
        {
            Console.WriteLine("You typed a number equal to 0!");
        }
        else
        {
            Console.WriteLine("You typed a number less than 0!");
        }
    }
}
