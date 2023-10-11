using System;


class Program
{
    static void Main(String[] args)
    { 
        int[] temperature = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        string[] names = { "Marcela", "Paula", "Pedro" };

        int size = temperature.Length;

        Console.WriteLine(temperature[0]);
        Console.WriteLine(temperature[1]);
        Console.WriteLine(temperature[2]);

        //for ( int i = 0; i < size; i++ )
        //{
        //    Console.WriteLine(temperature[i] );
        //}  

        foreach (string student in names)
        {
            Console.WriteLine(student);
        }

        int[] numbers = new int[3];
    }
}