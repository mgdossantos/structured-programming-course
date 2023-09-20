using System;

class Program
{
    static void Main(String[] args)
    {
        int number, guess, tries = 0,limitTries=5;

        Random rnd = new Random();

        number = rnd.Next(1, 1001);
        Console.WriteLine(number);
        Console.WriteLine("Guess a number: ");
        guess = int.Parse(Console.ReadLine());
        tries++;

        while (guess != number && tries<=limitTries)
        {
            Console.WriteLine("Guess a number: ");
            guess = int.Parse(Console.ReadLine());
            tries++;

            if(guess < number)
            {
                Console.WriteLine("The number is greater than your guess!!!");
            }

            else
            {
                Console.WriteLine("The number is less than your guess!!!");
            }

        }

        if(guess == number)
        {
            Console.WriteLine("You guess correctly with " + tries + " try(ies).");

        }
        else
        {
            Console.WriteLine("You achieve the limit of tries. The secret number was: "+number);

        }


    }
}
