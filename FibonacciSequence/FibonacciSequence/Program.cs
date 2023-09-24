using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(String[] args)
    {
        int a,b,c;

        a = 0;
        b = 1;
        Console.Write(a+" ");
        Console.Write(b+" ");
        for (int i = 0; i < 19; i++)
        {
            c = a + b;
            Console.Write(c+" ");
            a = b;
            b = c;
        }

        
    }
}
