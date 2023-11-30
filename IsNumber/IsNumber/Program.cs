using System;

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Type a year");
        string year= Console.ReadLine();

        while(!Char.IsNumber(year,0) || !Char.IsNumber(year, 1) || !Char.IsNumber(year, 2) || !Char.IsNumber(year, 3)){
            Console.WriteLine("Type a year with 4 digits. Please");
            year = Console.ReadLine();
        }
        
        int yearNumber = int.Parse(year);
            
    }

}
