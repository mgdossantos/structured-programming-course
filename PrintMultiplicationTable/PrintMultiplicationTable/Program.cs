using System;

class Program
{
    static void Main(String[] args)
    {
        int number,result;
        Console.WriteLine("Type the number to create its multiplicatin table: ");
        number= int.Parse(Console.ReadLine());

        for (int i = 0; i < 11; i++)
        {
            result = i * number;
            Console.WriteLine(number + " * "+i+" = "+result);
        }
    }
}
