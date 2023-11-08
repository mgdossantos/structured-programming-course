
using System;

namespace Employee
{
    struct Employee
    {
        int id;
        string position;
        int year;
        string name;

        public Employee(int id, string p, int y, string n)
        {
            this.id = id;
            this.position = p;
            this.year = y;
            this.name = n;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public string getName()
        {
            return this.name;
        }

        public void setPosition(string newPosition)
        {
            this.position = newPosition;
        }

        public string getPosition()
        {
            return this.position;
        }

        public void setYear(int newYear)
        {
            this.year = newYear;
        }

        public int getYear()
        {
            return this.year;
        }

        public void showInformation()
        {
            Console.WriteLine("--- Employee Information ---");
            Console.WriteLine("Name: " + this.getName());
            Console.WriteLine("Year: " + this.getYear());
            Console.WriteLine("Position: " + this.getPosition());
            Console.WriteLine("Years: " + this.calculationYear(2023));
            Console.WriteLine(" ");

        }

        public int calculationYear(int currentYear)
        {
            int years;

            years = currentYear - this.year;
            return years;
        }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Teacher", 2022, "Marcela");
            Employee e2 = new Employee(2, "Teacher", 2022, "Marcela");
            e1.showInformation();
            e2.showInformation();




        }

    }
}