using System;
using System.Diagnostics.Metrics;
class Program
{
    static void Main(string[] args)
    {
        double sensor;
        Console.WriteLine("Type the sensor reading: ");
        sensor = double.Parse(Console.ReadLine());
        switch (sensor)
        {
            case < 0.0:
                Console.WriteLine("The temperature "+sensor+" is too low. Be careful!!");
                break;

            case > 15.0:
                Console.WriteLine("The temperature "+sensor+" is too high. Be careful");
                break;

            case double.NaN:
                Console.WriteLine("Error!!!.");
                break;

            default:
                Console.WriteLine("The temperature "+sensor+ " in environment is safe!!");
                break;
        }
    }
}