using System;

class Program
{
    static void Main(String[] args)
    {
        int i;
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 4)
                break;
        }


        i = 0;
        while (i< 10)
        {
            Console.WriteLine(i);
            if (i == 4)
                break;
            
            i++;
        }


        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 4)
                continue;
        }



        i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
            if (i == 4)
                continue;

            
        }

    }
}
