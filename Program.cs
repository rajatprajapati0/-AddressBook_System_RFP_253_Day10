using System;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            AddressBook obj= new AddressBook();
            Console.WriteLine(obj.AddContact());    
        }
    }
}
