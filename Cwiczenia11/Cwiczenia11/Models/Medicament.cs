using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class Medicament
    {
        public Medicament()
        {
            Prescription_Medicament = new HashSet<Prescription_Medicament>();
        }

        public int IdMedicament { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Type { get; set; }

        public virtual ICollection<Prescription_Medicament> Prescription_Medicament { get; set; }
    }
}
