using System;

class Program
{
    static void Main(String[] args)
    {
        int number,guess;
        
        Random rnd = new Random();

        number = rnd.Next();
        Console.WriteLine(number);
        Console.WriteLine("Guess a number: ");
        guess = int.Parse(Console.ReadLine());


        while (guess!= number)
        {
            Console.WriteLine("Guess a number: ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("");

    }
}