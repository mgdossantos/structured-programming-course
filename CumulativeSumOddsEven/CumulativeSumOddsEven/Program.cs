using System;

class Program
{
    static void Main(string[] args)
    {
        int number,sumOdd,sumEven,sum;
        number = -1;
        sumOdd = 0;
        sumEven = 0;
        sum = 0;
        string numberString;
        numberString = "";

        while (number !=0)
        {
            Console.WriteLine("Type a number: ");
            number = int.Parse(Console.ReadLine());
            sum = sum + number;
            numberString = number + " - " + numberString;


            if (number == 0)
                break;
            else
            {
                if (number % 2 == 0)
                {
                    sumOdd = number + sumOdd;
                }

                else
                {
                    sumEven = number + sumEven;
                }

            }
           

        }
        Console.WriteLine("The number:" + numberString);

        Console.WriteLine("Cumulative sum for the odd numbers: "+sumOdd);
        Console.WriteLine("Cumulative sum for the even numbers: " + sumEven);
        Console.WriteLine("Cumulative sum for all numbers: " + sum);

    }
}