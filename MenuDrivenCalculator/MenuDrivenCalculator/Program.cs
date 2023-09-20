using System;

class Program
{
    static void Main(String[] args)
    {
        int op = 0,result = 0,n1,n2;

        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Finish");

            op = int.Parse(Console.ReadLine());

            if (op < 4 && op > 0)
            {
                Console.WriteLine("Type number 1: ");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Type number 2: ");
                n2 = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        result = n1 + n2;
                        break;
                    case 2:
                        result = n1 - n2;
                        break;
                    case 3:
                        result = n1 * n2;
                        break;
                    case 4:
                        result = n1 / n2;
                        break;


                }
            }

            if(op>4 || op<0)
                Console.WriteLine("You chose an invalid operator. Try again!!");
            else
                Console.WriteLine("Result: "+result);
            

                
        }
        while (op != 0);

        Console.WriteLine("Exit");

    }
}

