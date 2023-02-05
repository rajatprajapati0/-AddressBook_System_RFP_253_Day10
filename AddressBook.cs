using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBook
    {
        public Contact AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter your First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your City name ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State name");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your zipcode");
            contact.zipcode = Console.ReadLine();
            Console.WriteLine("Enter your Phone number");
            contact.Phone = Console.ReadLine();
            Console.WriteLine("Enter your email ");
            contact.Email = Console.ReadLine();
          
            return contact;
        }

    }
}
