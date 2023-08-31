using System;

class Program
{
    static void Main(string[] args)
    {
        int age;

        Console.WriteLine("A: ");
        age = int.Parse(Console.ReadLine());

        if (age < 18) {
            Console.WriteLine("Your age is less than 18!!");
        }
        else
        {
            if(age < 65)
            {
                Console.WriteLine("you are btw 18 and 65");
            }
            else
            {
                Console.WriteLine("your age is greater than 65");
            }


        }

    }
}
