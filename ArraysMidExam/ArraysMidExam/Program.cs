using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[];
        int number = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Type a number");
            number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }
            

        Console.WriteLine(numbers.Max());
        Console.WriteLine(numbers.Min());
        Console.WriteLine(numbers.Sum() / numbers.Length);
    }
}