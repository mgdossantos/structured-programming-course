using System;

class Program
{
    static void Main (string[] args)
    {
        string name,color,message;
        int age;

        Console.WriteLine("Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Age: ");
        age = int.Parse(Console.ReadLine());

    
        Console.WriteLine("Color: ");
        color = Console.ReadLine();

        message = "Hello";

        if (age < 0)
        {
            message = "You typed an invalid age";
            age = 0;
        }

        else
        {
            if (age < 18)
            {
                message = "Hello, young one!!";
            }
        }

        Console.WriteLine("--- User Information ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " +age);
        Console.WriteLine(message);
        Console.WriteLine("Color: " + color);
    }
}