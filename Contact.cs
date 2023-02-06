using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Contact
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State{ get; set; }  
        public string zipcode { get; set; }
        public string Country{ get; set; }
        public string Phone { get; set; } 
        public string Email { get; set; }



        public override string ToString()
        {
            return 
                @$"
                  Name: {FirstName}{LastName}
                  Address: {Address}
                  City: {City}
                  State: {State}
                  Zipcode: {zipcode}
                  Phone: {Phone}
                  Email: {Email}
                ";
        }

    }
}
