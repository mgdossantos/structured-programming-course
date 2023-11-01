using System;

/*you need to random generates the id
 * you need to create the property nameBorrower
you need to create the property status that will be boolean  
A= available B = borrowed
Create a library system (You must print a list of 10 books, ask for the name of the 
borrower, ask to select a book and print the selected book)*/

namespace Book
{
    struct Book
    {
        public int id;
        public string title;

        public Book(int id,string title)
        {
            this.id = id;
            this.title = title;
        }

        public void getId()
        {
            Console.WriteLine("Book ID: " + this.id);
        }

        public void setId(int id){
            this.id = id;
        }

        public void getTitle()
        {
            Console.WriteLine("Book Title: " + this.title);
        }

        public void setTitle(string title)
        {
            this.title= title;
        }
    }

 

    public class Program
    {
        

        static void Main(string[] args)
        {

             Book book1 = new Book();
            //book1.id = 001;
            book1.getId();
            book1.getTitle();

            int id;
            Console.WriteLine("Type the ID Title: ");
            id = int.Parse(Console.ReadLine());
            book1.setId(id);

            string title;
            Console.WriteLine("Type the Book Title: ");
            title = Console.ReadLine();
            book1.setTitle(title);
                      

            book1.getId();
            book1.getTitle();

            Book book2 = new Book(2569, "1984");
            book2.getId();
            book2.getTitle();
        }
    }
}
