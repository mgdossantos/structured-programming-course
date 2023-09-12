using System;

class Program
{
    static void Main(string[] args)
    {
        int number, sumOdd, sumEven, sum;
        sumOdd = 0;
        sumEven = 0;
        sum = 0;
        string numberString;
        numberString = "";
        do

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

        while (number != 0);

        Console.WriteLine("The number:" + numberString);

        Console.WriteLine("Cumulative sum for the odd numbers: " + sumOdd);
        Console.WriteLine("Cumulative sum for the even numbers: " + sumEven);
        Console.WriteLine("Cumulative sum for all numbers: " + sum);

    }
}