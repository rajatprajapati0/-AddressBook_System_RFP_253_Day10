using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBook
    {
        List<Contact> contacts;
        public AddressBook()
        {
            contacts = new List<Contact>();
        }

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
           contacts.Add(contact);   
            return contact;
        }

        public void View() 
        {

            if (contacts.Count <= 0)
            {
                Console.WriteLine("No contacts available");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine
                   (@$"
                      Name: {contact.FirstName} {contact.LastName}
                      Address: {contact.Address} 
                      City: {contact.City}
                      State: {contact.State}
                      Zipcode: {contact.zipcode}
                      PhoneNumber:{contact.Phone}
                      Email: {contact.Email}
                  ");

                }

        }   }

    }
}
