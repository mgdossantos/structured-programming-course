using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Lasalle Theater!!");
        Console.WriteLine("Type your age: ");
        int age;
        age = int.Parse(Console.ReadLine());
        double ticketprice;

        if (age >= 0 || age <= 12)
        {
            ticketprice = 5;
        }
        else if(age > 12 || age <= 17)
        {
            ticketprice = 7.50;
        }
        else if(age >17 || age <= 64)
        {
            ticketprice = 10;
        }
        else
        {
            ticketprice = 6.50;
        }

        Console.WriteLine($"Your ticket price is: ${ticketprice:F2}");
    }
}