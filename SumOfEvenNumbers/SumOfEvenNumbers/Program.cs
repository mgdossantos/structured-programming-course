using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(String[] args)
    {
        int sum= 0;

        for (int i = 0; i <6; i++) {
            if (i % 2 == 0)
                sum = sum+ i;
        }

        Console.WriteLine("The sum of the first 50 even numbers is: "+sum);
    }
}
