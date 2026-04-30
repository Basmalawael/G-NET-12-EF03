using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02.Model
{
    internal class Profile 
    {   
        public int ProfileID { get; set; }  
        public string Bio {  get; set; }
        public string WebsiteURL { get; set; }
        public string LogoPath { get; set; }

        //Navigation Property:
        public Organizer OrganizerProf { get; set; }
        public int OrganizerID { get; set; } //Fk 

    }
}
