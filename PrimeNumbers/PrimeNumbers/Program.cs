using System;

class Program
{
    static void Main(String[] args)
    {
        int count=0;
        for (int i=1;i<=100;i++)
        {
            //Console.WriteLine(i);
            count = 0;
            for (int j = i; j >= 1; j--)
            {
                //Console.WriteLine(j);
                
                if (i%j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(i);
            }
        }


    }
}

