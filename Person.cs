using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
     public class Person
     {
        public List<Contact> contacts { get; set; }

        public Person()
        {
            contacts = new List<Contact>();

        }

        public override string ToString()
        {
            Contact contact = new Contact();
            string result = "";
            result = result + "\ncontact:";
            foreach (Contact details in contacts)
            {
                result += details.ToString();
            }

            return result;
        }

    }
}
 