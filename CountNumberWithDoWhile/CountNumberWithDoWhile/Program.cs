using System;

class Program
{
    static void Main(string[] args)
    {
        int count;

        count = 0;
        do
        {
            Console.WriteLine("Number: " + count);
            count++;
        }
        while (count < 11);
    }
}