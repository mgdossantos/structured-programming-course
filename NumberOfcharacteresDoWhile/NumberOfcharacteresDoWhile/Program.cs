using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int number;
        bool valid;

        do
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();

            number = name.Length;

            if (number >= 3)
            {
                valid = true;
                Console.WriteLine("Name need to have three or more characteres!! Try again!!");
            }
                
            else
                valid = false;
        }
        while(valid!=true);

        Console.WriteLine("You entire valid information!!");

    }
}
