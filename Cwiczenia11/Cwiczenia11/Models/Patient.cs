using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class Patient
    {
        public Patient()
        {
            Prescription = new HashSet<Prescription>();
        }


        public int IdPatient { get; set; }
        public String FirstName { get; set; }
        public String   LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}
