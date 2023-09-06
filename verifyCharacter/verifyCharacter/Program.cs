using System;

class Program
{
    static void Main(string[] args)
    {
        char ch;

        Console.WriteLine("Type one character: ");
        ch=char.Parse(Console.ReadLine());

        if (char.IsUpper(ch))
        {
            Console.WriteLine("You typed a uppercase character");
        }
        else
        {
            if (char.IsLower(ch))
            {
                Console.WriteLine("You typed a lowercase character");
            }
            else
            {
                if (char.IsDigit(ch))
                {
                    Console.WriteLine("You typed a digit");
                }
                else
                {
                    Console.WriteLine("You did not type an number or a leeter!!");
                }
            }
        }

    }
}