using System;

class Proram
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Coffe Machine v1.0---");
        Console.WriteLine("-Menu-");
        Console.WriteLine("1 - Cappuccino");
        Console.WriteLine("2 - Expresso");
        Console.WriteLine("3 - Mochaccino");
        int op = int.Parse(Console.ReadLine());


        switch (op)
        {
            case 1:
                Console.WriteLine("Your cappucciono is ready");
                break;
            case 2:
                Console.WriteLine("Your expresso is ready");
                break;

            case 3:
                Console.WriteLine("Your mochaccino is ready");
                break;

            default:
                Console.WriteLine("You chose an invalid option.");
                break;

        }


    }
}