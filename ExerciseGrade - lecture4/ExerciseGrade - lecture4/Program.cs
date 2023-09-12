using System;


class Program
{
    static void Main(string[] args)
    {
        double grade;
        string gradeName;

        Console.WriteLine("Type your grade (0-100)");
        grade = double.Parse(Console.ReadLine());

        switch (grade)
        {
            case >=90 and <=100:
                gradeName = "A";
                break;

            case >= 80 and < 90:
                gradeName = "B";
                break;

            case >= 70 and < 80:
                gradeName = "C";
                break;

            case >=60 and < 70:
                gradeName = "D";
                break;
            case >=0 and <60:
                gradeName = "F";
                break;

            default:
                gradeName = "I";
                break;

        }
        Console.WriteLine(grade + " = " + gradeName);
    }
}