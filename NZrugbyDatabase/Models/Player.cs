using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NZrugbyDatabase.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public string Position { get; set; }

        public string Contact { get; set; }

        public int TeamID { get; set; }      

        public Team Team { get; set; }
    }
}
