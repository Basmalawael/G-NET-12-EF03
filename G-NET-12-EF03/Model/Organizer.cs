using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02.Model
{
    internal class Organizer
    { 
        [Key] 
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int OrganizerID { get; set; }

        [Required (ErrorMessage = " Name Is Required ")]
        public string Name { get; set; }

        [MaxLength(100)]
        public string NameOfCompany { get; set; }

        public bool IsVerified { get; set; }


        //Navigation Property: One To One
        public Profile? ProfileOrg { get; set; } 
     
        public ICollection <Event> OrgEvent { get; set; } = new HashSet<Event> ();


    }
}
