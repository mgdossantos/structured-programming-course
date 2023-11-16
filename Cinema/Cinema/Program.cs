using System;

namespace Cinema
{
    struct Ticket
    {
        int id;
        string titleMovie;
        int duration;
        int type;
        double price;
        bool statusOccupation;

        public Ticket(int id, string title, int duration)
        {
            this.id = id;
            this.titleMovie = title;
            this.duration = duration;
            this.type = 0;
            this.price = 0;
            this.statusOccupation = false;

        }

        public int getId() { return id; }
        public string getTitle() { return titleMovie; }
        public int getDuration() { return duration; }
        public int getType() { return type; }
        public double getPrice() { return price; }
        public bool getStatusOccupation() {  return statusOccupation; }

        public void setStatusOccupation(bool status)
        {
            this.statusOccupation |= status;
        }
        public void setPrice()
        {
            if (this.type == 1)
                this.price = 22.90 * 0.5;
            else if (this.type == 2)
                this.price = 22.90 * 0.3;
            else if (this.type == 3)
                this.price =  22.90 ;

            this.price = Math.Round(this.price * 1.15,2);
        }

        public void setType(int type)
        {
            this.type = type;
        }

        public void showInformation()
        {
            Console.WriteLine("--Ticket Info.--");
            Console.Write("ID: " + this.getId()+ " ");
            Console.Write(" - Title: "+this.getTitle()+ " ");
            Console.Write("- Duration: "+this.getDuration()+" ");
            Console.Write("- Type: "+this.getType() + " ");
            Console.Write("- Price: "+this.getPrice() + " ");
            Console.WriteLine("- Status: "+this.getStatusOccupation());
        }

        


    }

    public class Program
    {
        static void Main(string[] args)
        {
            Ticket[] room1 = new Ticket[3];
            Ticket[] room2 = new Ticket[3];
            Ticket[] room3 = new Ticket[3];

            int movie,id,type,chair, ticketsReamining;


            int op=-1;
            while (op!=0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Open the Cinema");
                Console.WriteLine("2 - Sell ticket for movie");
                Console.WriteLine("3 - Show Information for a specific Ticket(ID)");
                Console.WriteLine("4 - Show Information about tickets for a specific movie");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        Console.WriteLine("Enter info for movie 1");
                        Console.WriteLine(" Title: ");
                        string movieTitle = Console.ReadLine();
                        Console.WriteLine("Duration: ");
                        int movieDuration = int.Parse(Console.ReadLine());

                        for (int i = 0; i < 3; i++)
                        {

                            room1[i] = new Ticket(i + 1, movieTitle, movieDuration);

                        }

                        Console.WriteLine("Enter info for movie 2");
                        Console.WriteLine(" Title: ");
                        movieTitle = Console.ReadLine();
                        Console.WriteLine("Duration: ");
                        movieDuration = int.Parse(Console.ReadLine());

                        for (int i = 0; i < 3; i++)
                        {

                            room2[i] = new Ticket(i + 1, movieTitle, movieDuration);

                        }

                        Console.WriteLine("Enter info for movie 3");
                        Console.WriteLine(" Title: ");
                        movieTitle = Console.ReadLine();
                        Console.WriteLine("Duration: ");
                        movieDuration = int.Parse(Console.ReadLine());

                        for (int i = 0; i < 3; i++)
                        {

                            room3[i] = new Ticket(i + 1, movieTitle, movieDuration);

                        }
                        break;

                    case 2:
                        
                        Console.WriteLine("1 - Movie 1, 2 - Movie 2, 3 - Movie 3");
                        movie=int.Parse(Console.ReadLine());
                        Console.WriteLine("1 - Student, 2 - Senior, 3 - Adult");
                        type = int.Parse(Console.ReadLine());
                        Console.WriteLine("Choose a chair: ");
                        chair = int.Parse(Console.ReadLine());

                        if(movie == 1)
                        {
                            if (room1[chair - 1].getStatusOccupation() == false)
                            {
                                room1[chair - 1].setStatusOccupation(true);
                                room1[chair - 1].setType(type);
                                room1[chair - 1].setPrice();
                            }
                            else
                            {
                                Console.WriteLine("Try another chair!!!");
                            }
                        }

                        if (movie == 2)
                        {
                            if (room2[chair - 1].getStatusOccupation() == false)
                            {
                                room2[chair - 1].setStatusOccupation(true);
                                room2[chair - 1].setType(type);
                                room2[chair - 1].setPrice();
                            }
                            else
                            {
                                Console.WriteLine("Try another chair!!!");
                            }
                        }

                        if (movie == 3)
                        {
                            if (room3[chair - 1].getStatusOccupation() == false)
                            {
                                room3[chair - 1].setStatusOccupation(true);
                                room3[chair - 1].setType(type);
                                room3[chair - 1].setPrice();
                            }
                            else
                            {
                                Console.WriteLine("Try another chair!!!");
                            }
                        }


                        break;

                    case 3:
                        Console.WriteLine("1 - Movie 1, 2 - Movie 2, 3 - Movie 3");
                        movie = int.Parse(Console.ReadLine());
                        Console.WriteLine("Type the ID: ");
                        id = int.Parse(Console.ReadLine());

                        if (movie == 1)
                        {
                            foreach (Ticket ticketMovie1 in room1)
                            {
                                if (ticketMovie1.getId() == id)
                                {
                                    ticketMovie1.showInformation();
                                    break;
                                }

                            }
                        }

                        if (movie == 2)
                        {
                            foreach (Ticket ticketMovie1 in room2)
                            {
                                if (ticketMovie1.getId() == id)
                                {
                                    ticketMovie1.showInformation();
                                    break;
                                }

                            }
                        }

                        if (movie == 3)
                        {
                            if (movie == 1)
                            {
                                foreach (Ticket ticketMovie1 in room3)
                                {
                                    if (ticketMovie1.getId() == id)
                                    {
                                        ticketMovie1.showInformation();
                                        break;
                                    }

                                }
                            }
                        }

                        break;

                        case 4:
                        Console.WriteLine("1 - Movie 1, 2 - Movie 2, 3 - Movie 3");
                        movie = int.Parse(Console.ReadLine());
                        if(movie == 1)
                        {
                            ticketsReamining = 0;
                            Console.WriteLine("Info for movie 1");
                            foreach (Ticket ticketMovie1 in room1)
                            {
                                ticketMovie1.showInformation();
                                if (ticketMovie1.getStatusOccupation() == false)
                                {
                                    ticketsReamining++;
                                }
                            }
                            Console.WriteLine("Total tickets remaining: " + ticketsReamining);
                        }

                        if (movie == 2)
                        {
                            ticketsReamining = 0;
                            Console.WriteLine("Info for movie 2");

                            foreach (Ticket ticketMovie1 in room2)
                            {
                                ticketMovie1.showInformation();
                                if (ticketMovie1.getStatusOccupation() == false)
                                {
                                    ticketsReamining++;
                                }

                            }
                            Console.WriteLine("Total tickets remaining: " + ticketsReamining);
                        }

                        if(movie == 3)
                        {
                            ticketsReamining = 0;
                            Console.WriteLine("Info for movie 3");

                            foreach (Ticket ticketMovie1 in room3)
                            {
                                ticketMovie1.showInformation();
                                if (ticketMovie1.getStatusOccupation() == false)
                                {
                                    ticketsReamining++;
                                }
                            }
                            Console.WriteLine("Total tickets remaining: "+ticketsReamining);
                        }
                        
                        break;

                    case 5:
                        for(int i = 0; i < 3; i++)
                        {
                            room1[i].showInformation();
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            room2[i].showInformation();
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            room3[i].showInformation();
                        }

                        break;


                }
                     }
            }
    }
}