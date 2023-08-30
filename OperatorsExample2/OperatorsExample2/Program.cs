
using System;

class Program
{
    static void Main(string[] args)
    {
        double total;
        total = 39;
        total += 5;
        total -= 2;
        Console.WriteLine(total);
        
        int value1, value2;
        value1 = 25;
        value2 = 50;
        bool result;
        Console.WriteLine("value1: " + value1);
        Console.WriteLine("value2: " + value2);
        
        result = value1 > value2;
        Console.WriteLine("value1 < value2: " + result);

        result = value1 < value2;
        Console.WriteLine("value1 > value2: " + result);

        result = value1 == value2;
        Console.WriteLine("value1 == value2: " + result);


        bool isSunny, isWarm,isNiceDay,isConfortableDay;
        isSunny = false;
        isWarm = true;

        isNiceDay = isSunny && isWarm;
        isConfortableDay = isSunny || isWarm;

        Console.WriteLine("It is a Nice Day? " + isNiceDay);
        Console.WriteLine("It is a Confortable Day? " + isConfortableDay);





    }
}