using System;

class Program
{
    static void Main(string[] args)
    {
        int op;
        Console.WriteLine("Menu of Examples Lecture 5");
        Console.WriteLine("1 - Example 1");
        Console.WriteLine("2 - Example 2");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                int number;
                number = 0;

                while (number <11)
                {
                    Console.WriteLine("Number: " + number);
                    number++;
                }
                
                break;

            case 2:
                int secretNumber = 123;
                int guess;
                int numberTry=0;
                int limitTries = 4;

                Console.WriteLine("Guess a number: ");
                guess = int.Parse(Console.ReadLine());
                numberTry++;

                while ((guess != secretNumber) && (numberTry<=limitTries))
                {
                    Console.WriteLine("You chose wrong.Try again!!");
                    if (guess > secretNumber)
                    {
                        Console.WriteLine("The secret number is less than the number that you chose.");
                    }
                    else
                    {
                        Console.WriteLine("The secret number is greater than the number that you chose.");
                    }
                    Console.WriteLine("Guess a number: ");
                    guess = int.Parse(Console.ReadLine());
                    numberTry++;

                }
                if(guess == secretNumber)
                {
                    Console.WriteLine("You guess the right number with "+numberTry+" try(ies)!!");
                }
                else
                {
                    Console.WriteLine("You reached  the limits of tries. so soorry!!");
                }
                    
             
                break;

        }
    }
}
