using System;

class Program
{
    static void Main(String[] args)
    {
        int number, guess,tries=0;

        Random rnd = new Random();

        number = rnd.Next(1,1001);
        Console.WriteLine(number);
        Console.WriteLine("Guess a number: ");
        guess = int.Parse(Console.ReadLine());
        tries++;

        while (guess != number)
        {
            Console.WriteLine("Guess a number: ");
            guess = int.Parse(Console.ReadLine());
            tries++;

        }

        Console.WriteLine("You guess correctly with "+ tries+ " try(ies).");

    }
}
