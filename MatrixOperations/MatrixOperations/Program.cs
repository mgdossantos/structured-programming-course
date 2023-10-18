using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Matrix A");
        int[,] matrix3 = new int[2, 2];
        int row3 = matrix3.GetLength(0);
        int column3 = matrix3.GetLength(1);

        for (int i = 0; i < row3; i++)
        {
            for (int j = 0; j < column3; j++)
            {
                Console.WriteLine("Type a number [" + i + "," + j + "]");
                matrix3[i, j] = int.Parse(Console.ReadLine());

            }
        }



        int[,] matrix4 = new int[2, 2];
        int row4 = matrix3.GetLength(0);
        int column4 = matrix3.GetLength(1);
        Console.WriteLine("Matrix B");
        for (int i = 0; i < row4; i++)
        {
            for (int j = 0; j < column4; j++)
            {
                Console.WriteLine("Type a number [" + i + "," + j + "]");
                matrix4[i, j] = int.Parse(Console.ReadLine());

            }
        }




        //Operations
        int[,] sum = new int[3, 3];
        int[,] sub = new int[3, 3];

        for (int i = 0; i < row3; i++)
        {
            for (int j = 0; j < column3; j++)
            {

                sum[i, j] = matrix3[i, j] + matrix4[i, j];
                sub[i, j] = matrix3[i, j] - matrix4[i, j];

            }
        }

        Console.WriteLine("Matrix A");
        for (int i = 0; i < row3; i++)
        {
            for (int j = 0; j < column3; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + matrix3[i, j] + " ");
                }
                else if (j == column3 - 1)
                {
                    Console.Write(matrix3[i, j] + " ]");

                }
                else
                {
                    Console.Write(matrix3[i, j] + " ");
                }

            }
            Console.WriteLine();
        }

        Console.WriteLine("Matrix B");
        for (int i = 0; i < row4; i++)
        {
            for (int j = 0; j < column4; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + matrix4[i, j] + " ");
                }
                else if (j == column4 - 1)
                {
                    Console.Write(matrix4[i, j] + " ]");

                }
                else
                {
                    Console.Write(matrix4[i, j] + " ");
                }

            }
            Console.WriteLine();
        }

        Console.WriteLine("Sum");
        for (int i = 0; i < row4; i++)
        {
            for (int j = 0; j < column4; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + sum[i, j] + " ");
                }
                else if (j == column4 - 1)
                {
                    Console.Write(sum[i, j] + " ]");

                }
                else
                {
                    Console.Write(sum[i, j] + " ");
                }

            }
            Console.WriteLine();
        }

        Console.WriteLine("Sub");

        for (int i = 0; i < row4; i++)
        {
            for (int j = 0; j < column4; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + sub[i, j] + " ");
                }
                else if (j == column4 - 1)
                {
                    Console.Write(sub[i, j] + " ]");

                }
                else
                {
                    Console.Write(sub[i, j] + " ");
                }

            }
            Console.WriteLine();
        }

    }
}