using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02.Model
{
    
    internal class Registration
    {
    
        public string Notes { get; set; }
        public DateTime RegistrationDate { get; set; }

        //RS :

        //Navigation 
        public Attendee ReAttendee { get; set; }
        public Event ReEvent { get; set; }

        //FK 
        public int AttendeeID { get; set; }
        public int EventID { get; set; }



} 
}