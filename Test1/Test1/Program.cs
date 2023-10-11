//You have been assigned to write a C# program that calculates simple
//statistics from a user-supplied list of numbers. The program should
//allow
//the user to enter a series of integers and then
//calculate and display the
//following statistics:


//Average of the numbers entered.
//Largest number entered.
//Lowest number entered.
//Number of even and odd numbers entered.

//Program requirements:

//The program must use a loop to allow the user to enter multiple
//numbers
//until he wants to stop.After entering the numbers,
//the program should
//display the statistics listed above.
//The program should allow the user to decide whether
//to perform another
//statistics calculation with a new list of numbers or
//terminate the program.
//Remember to use conditionals (if/else) to check whether
//numbers are even or
//odd and to determine the largest and smallest number entered.


using System;

class Program
{
    static void Main(string[] args)
    {
        int number, sum, largest, lowest, qtdodds, qtdeven, cont;
        double average;
        
        char op;
        op = 's';

        while (op != 'n')
        {
            number = 0;
            sum = 0;
            cont = 0;
            largest = Int32.MinValue;
            lowest = Int32.MaxValue;
            qtdodds = 0;
            qtdeven = 0; 
            cont=0;
            average = 0;
            do
            {
                Console.WriteLine("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                if (number != -1)
                {
                    sum = sum + number;
                    cont++;
                    if (number > largest)
                    {
                        largest = number;
                    }

                    if (number < lowest)
                    {
                        lowest = number;
                    }

                    if (number % 2 == 0)
                    {
                        qtdodds++;
                    }
                    else
                    {
                        qtdeven++;
                    }

                }

            } while (number != -1);

            average = ((double)sum / cont);

            Console.WriteLine("Average: " + average);
            Console.WriteLine("Largest: " + largest);
            Console.WriteLine("Lowest: " + lowest);
            Console.WriteLine("Perform another statistics calculation with a new list of numbers");
            Console.WriteLine("y - New Calculation!");
            Console.WriteLine("n - Terminate the program!");
            op = char.Parse(Console.ReadLine());
        }
       

    }
}