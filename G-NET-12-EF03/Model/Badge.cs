using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02.Model
{
    internal class Badge 
    { 
        public int BadgeID { get; set; }
        public string BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public Tier Tier {  get; set; }

        // Navigation 
        public Attendee BagdeAtt { get; set; }
        //FK 
        public int AttendeeID { get; set; }


     }
}
