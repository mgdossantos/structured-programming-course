using System;

class Program
{
    static void Main(String[] args)
    {
        int number,sum;
        number = 0;
        sum = 0;
        while (number<=100)
        {
            sum = sum + number;
            number++;

        }

        Console.WriteLine("Sum of first 100 natural numbers: "+sum);

    }
}