// Write a program that give the largest number from a sequence type for the user one by one.
// To finalize the program, the user can enter -1

using System;
using System.Runtime.InteropServices;

class Program { 

    static void Main(string[] args)
    {
        int number,largestNumber;

        Console.WriteLine("Enter the number: ");
        number = int.Parse(Console.ReadLine());
        largestNumber = number;

        while (number !=-1)
        {
            if (number > largestNumber)
                largestNumber = number;
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("The largest number is: "+largestNumber);
    }
}