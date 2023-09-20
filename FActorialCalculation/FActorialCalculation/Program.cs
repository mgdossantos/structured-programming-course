using System;

class Program
{
    static void Main(String[] args)
    {
        int number, factorial=1, i=1;
        Console.WriteLine("Type the number to calculate its factorial: ");
        number = int.Parse(Console.ReadLine());
        do
        {
            factorial = factorial * i;
            i++;


        }
        while (i<=number);

        Console.WriteLine("The factorial of "+number+" : "+factorial);

    }
}
