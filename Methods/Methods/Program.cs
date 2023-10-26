using System;

class Program
{
    static string checkNumber(int number)
    {
        if (number > 0)
        {
            return "Positive";
        }
        else
        {
            return "Negative";
        }
    }

    static void formatOutput(string output)
    {
        Console.WriteLine("The number is " + output+" !!!");
    }

    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Type a number: ");
        n = int.Parse(Console.ReadLine());
        string result;
        result= checkNumber(n);
        formatOutput(result);
    }
}