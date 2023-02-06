using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBook
    {
        public Person person;
        public AddressBook()
        {
            person = new Person();

        }

        public void Edit()
        {
            Console.WriteLine("enter name in which you want edit");
            string name=Console.ReadLine();
            Contact contact = null;
            foreach( var item in person.contacts)
             {

                if (item.FirstName.Equals( name)) 
                {
                
                 contact= item ;
                    
                }
            }
            if (contact  != null)
            {

                   contact = AddContact();
                for (int i = 0; i < person.contacts.Count; i++)
                {
                    if (person.contacts[i].FirstName.Equals(name))
                    {
                        person.contacts.RemoveAt(i);
                        person.contacts[i] = contact;
                        Console.WriteLine("edited");
                    }
                }
            }
            else { Console.WriteLine("contact is not present "); }


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
            person.contacts.Add(contact);
            return contact;
        }

        public void View()
        {
            Console.WriteLine(person.ToString());
        }
    }
}
