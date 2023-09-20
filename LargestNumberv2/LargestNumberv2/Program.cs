// Write a program that give the largest number from a sequence type for the user one by one.
// To finalize the program, the user can enter -1

using System;
using System.Runtime.InteropServices;

class Program
{

    static void Main(string[] args)
    {
        int number, largestNumber,counterValid=0;

        
        largestNumber = -100000000;

        while (true)
        {
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            if (number != -1)
            {
                counterValid++;
                if (number > largestNumber)
                    largestNumber = number;
            }
            else
                break;
      
           

        }
        if (counterValid == 0)
            Console.WriteLine("You haven't entered any number!!");
        else
            Console.WriteLine("The largest number is: " + largestNumber);
    }
}