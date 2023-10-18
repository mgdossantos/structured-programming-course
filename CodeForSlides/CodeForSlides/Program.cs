using System;


class Program
{
    static void Main(String[] args)
    {
        
        
        double[] temperature = new double[];
        
        for (int i = 0; i < temperature.Length; i++)
        {
            Console.WriteLine("Type the temperature: ");
            temperature[i] = double.Parse(Console.ReadLine());
        }

        Array.Sort(temperature);
        for (int i = 0; i < temperature.Length; i++)
        {
            Console.WriteLine(temperature[i]);
            
        }

        int element;
        Console.WriteLine("Element to search: ");
        element = int.Parse(Console.ReadLine());
        int index = Array.IndexOf(temperature, element);
        Console.WriteLine("The element is in the index: " + index);
        int indexLast = Array.LastIndexOf(temperature, element);
        Console.WriteLine("The element is in the last index: " + indexLast);

        Console.WriteLine($"{string.Join(", ", temperature)}");
        Array.Resize(ref temperature, temperature.Length+2);
        Console.WriteLine($"{string.Join(", ", temperature)}");

       






    }
}