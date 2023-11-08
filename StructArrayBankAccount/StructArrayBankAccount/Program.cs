
using System;

namespace BankAccount
{
    struct BankAccount
    {
        int id;
        string name;
        string address;
        float balance;
        char type;

        public BankAccount(int id, string name, string address, float balance, char type)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.balance = balance;
            this.type = type;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public string getName()
        {
            return this.name;
        }

        public void setAddress(string newAddress)
        {
            this.address = newAddress;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setType(string type)
        {
            if (type.ToLower() == "chequings")
                this.type = 'c';
            else if (type.ToLower() == "savings")
                this.type = 's';
            else
                this.type = 'i';
        }

        public string getType()
        {
            if (this.type == 'c')
                return "Chequings";
            else if (this.type == 's')
                return "Savings";
            else
                return "Invalid";

        }

        public void setBalance(float newBalance)
        {
            this.balance = newBalance;
        }

        public float getBalance()
        {
            return this.balance;
        }

        public void showInformation()
        {
            Console.WriteLine("--- Bank Account Information ---");
            Console.WriteLine("Name: " + this.getName());
            Console.WriteLine("Type: " + this.getType());
            Console.WriteLine("Address: " + this.getAddress());
            Console.WriteLine("Balance: " + this.getBalance());
            Console.WriteLine(" ");

        }

        public void withDrawl(float money)
        {
            if (this.balance - money >= 0)
            {
                this.balance = this.balance - money;
                Console.WriteLine("Sucessful Withdrawl");
                Console.WriteLine("New balance: " + this.getBalance());
            }
            else
            {
                Console.WriteLine("You CAN NOT do this Withdrawl");
                Console.WriteLine("Check your balance: " + this.getBalance());
            }


        }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] bank1 = new BankAccount[3];
            for(int i =0; i< 3; i++)
            {
                bank1[i] = new BankAccount();
                Console.WriteLine(" Name: ");
                bank1[i].setName(Console.ReadLine());
                Console.WriteLine("Address: ");
                bank1[i].setAddress(Console.ReadLine());
                Console.WriteLine("Initial balance: ");
                bank1[i].setBalance(float.Parse(Console.ReadLine()));
                Console.WriteLine("Bank account type: Chequings or Savings");
                bank1[i].setType(Console.ReadLine());
            }

            foreach(BankAccount i in bank1)
            {
                i.showInformation();
            }


            

            float moneyWithDrawl;
            Console.WriteLine("How much you want to withdrawl? ");
            moneyWithDrawl = float.Parse(Console.ReadLine());
            bank1[0].withDrawl(moneyWithDrawl);
            bank1[0].showInformation();
        }

    }
}