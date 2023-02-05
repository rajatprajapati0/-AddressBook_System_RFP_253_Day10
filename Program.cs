using System;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            AddressBook obj= new AddressBook();
            while (true)
            {
                Console.WriteLine("select an option\na - add a new contact\nb -view all contacts\nc -edit contact");
                string input = Console.ReadLine();
                char option = input[0];
                switch (option)
                {
                    case 'a':
                        obj.AddContact();
                        break;
                    case 'b':
                        obj.View();
                        break;
                    case 'c':
                        obj.Edit();
                        break;
                    default:
                        Console.WriteLine("select right option");
                        break;
                }
            }
        }
    }
}
