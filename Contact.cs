using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Contact
    {

        public string FirstName;
        public string LastName;
        public string Address ;
        public string City ;
        public string State;  
        public string zipcode  ;
        public string Country;
        public string Phone ; 
        public string Email ;

        public override string ToString()
        {
          return @$"
          Name: {FirstName} {LastName}
          Address: {this.Address} 
          City: {this.City}
          State: {this.State}
          Zipcode: {this.zipcode}
          PhoneNumber:{this.Phone}
          Email: {this.Email}
          ";
        }


    }
}
