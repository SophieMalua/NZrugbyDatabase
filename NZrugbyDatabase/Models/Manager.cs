using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NZrugbyDatabase.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")] 
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public int Experience { get; set; }

        public int TeamID { get; set; }

        public Team Team { get; set; }

        internal static Task<object> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
