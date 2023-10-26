using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Matrix A");
        int[,] A = new int[2, 3];
        int rowA = A.GetLength(0);
        int columnA = A.GetLength(1);

        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < columnA; j++)
            {
                Console.WriteLine("Type a number [" + i + "," + j + "]");
                A[i, j] = int.Parse(Console.ReadLine());

            }
        }



        int[,] B = new int[3, 2];
        int rowB = B.GetLength(0);
        int columnB = B.GetLength(1);

        Console.WriteLine("Matrix B");
        for (int i = 0; i < rowB; i++)
        {
            for (int j = 0; j < columnB; j++)
            {
                Console.WriteLine("Type a number [" + i + "," + j + "]");
                B[i, j] = int.Parse(Console.ReadLine());

            }
        }




        //Operations
        /*int[,] sum = new int[2, 2];
        int[,] sub = new int[2, 2];
        
        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < columnA; j++)
            {

                sum[i, j] = A[i, j] + B[i, j];
                sub[i, j] = A[i, j] - B[i, j];

            }
        }*/

        int[,] mul = { { 0, 0 }, { 0, 0 }, { 0, 0 } };

        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < columnB; j++)
            {
                
                for (int k = 0; k < rowA; k++)
                {
                    mul[i, j] = mul[i, j] + A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("Matrix A");
        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < columnA; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + A[i, j] + " ");
                }
                else if (j == columnA - 1)
                {
                    Console.Write(A[i, j] + " ]");

                }
                else
                {
                    Console.Write(A[i, j] + " ");
                }

            }
            Console.WriteLine();
        }

        /*Console.WriteLine("Transpose A");
        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < columnA; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + A[j, i] + " ");
                }
                else if (j == columnA - 1)
                {
                    Console.Write(A[j, i] + " ]");

                }
                else
                {
                    Console.Write(A[j, i] + " ");
                }

            }
            Console.WriteLine();
        }*/

        Console.WriteLine("Matrix B");
        for (int i = 0; i < rowB; i++)
        {
            for (int j = 0; j < columnB; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + B[i, j] + " ");
                }
                else if (j == columnB - 1)
                {
                    Console.Write(B[i, j] + " ]");

                }
                else
                {
                    Console.Write(B[i, j] + " ");
                }

            }
            Console.WriteLine();
        }
        /*
        Console.WriteLine("Sum");
        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < columnA; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + sum[i, j] + " ");
                }
                else if (j == columnA - 1)
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

        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < columnA; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + sub[i, j] + " ");
                }
                else if (j == columnA - 1) 
                {
                    Console.Write(sub[i, j] + " ]");

                }
                else
                {
                    Console.Write(sub[i, j] + " ");
                }

            }
            Console.WriteLine();
        }*/

        int rowM = mul.GetLength(0);
        int columnM = mul.GetLength(1);
        Console.WriteLine("Multiplication");
        for (int i = 0; i < rowM; i++)
        {
            for (int j = 0; j < columnM; j++)
            {
                if (j == 0)
                {
                    Console.Write("[" + mul[i, j] + " ");
                }
                else if (j == columnM - 1)
                {
                    Console.Write(mul[i, j] + " ]");

                }
                else
                {
                    Console.Write(mul[i, j] + " ");
                }

            }
            Console.WriteLine();
        }

    }
}
