using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02.Model
{
    internal class Attendee 
    {
        public int AttendeeID { get; set; }

        public string FullName { get; set; }  

        public string Email {  get; set; }

        public Address Address { get; set; } 

        //Navigation 
        public Badge? AttendeeBadge { get; set; }   

        public  ICollection <Registration> ATTRegistration { get; set; }   
    }

    //Street, City, Country, PostalCode
    public class Address
    {
        public string Country { get; set; } 
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
}
