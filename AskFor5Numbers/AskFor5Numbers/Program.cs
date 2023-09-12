using System;

class Program
{
    static void Main(string[] args)
    {
        int count,a;
        count = 1;
        while (count < 6)
        {
            Console.WriteLine("Type the number "+count+": ");
            a = int.Parse(Console.ReadLine());
            count++;

        }

    }
}