using System;

class Program
{
    static void Main(string[] args)
    {
        int op;
        Console.WriteLine("Menu");
        Console.WriteLine("1 - Exercise  1");
        Console.WriteLine("2 - Exercise  2");
        op=int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("please type your grade: ");
                double grade;
                string gradeName;
                grade = double.Parse(Console.ReadLine());

                if (grade >= 90 && grade <= 100)
                    gradeName = "A";
                else if (grade >= 80 && grade <= 89)
                    gradeName = "B";
                else if (grade >= 70 && grade <= 79)
                    gradeName = "C";
                else if (grade >= 60 && grade <= 69)
                    gradeName = "D";
                else if (grade >=0 && grade < 60)
                    gradeName = "F";
                else
                    gradeName = "Invalid";

                Console.WriteLine(gradeName);
                break;




            case 2:
                Console.WriteLine("This is a coffe machine");
                Console.WriteLine("Choose your cooffee: ");
                Console.WriteLine("1 - Cappuccino ");
                Console.WriteLine("2 - Mochaccino ");
                Console.WriteLine("3 - Expresso ");
                Console.WriteLine("4 - Chocolate ");
                int type;
                type = int.Parse(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        Console.WriteLine("Your coffe (CAPPUCCINO) is ready");
                        break;
                    case 2:
                        Console.WriteLine("Your coffe (MOCHACCINO) is ready");
                        break;
                    case 3:
                        Console.WriteLine("Your coffe (EXPRESSO) is ready");
                        break;
                    case 4:
                        Console.WriteLine("Your coffe (CHOCOLATE) is ready");
                        break;
                    default:
                        Console.WriteLine("Sorry :( Your option is invalid!!");
                        break;

                }




                break;

            default:
                Console.WriteLine("Invalid option!!");
                break;

        }

    }
}
