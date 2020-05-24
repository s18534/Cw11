using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class Prescription_Medicament
    {
        public int IdMedicament { get; set; }
        public int IdPrescription { get; set; }
        public int Dose { get; set; }
        public String Details { get; set; }

        public virtual Medicament IdMedicamentMy { get; set; }
        public virtual Prescription IdPrescriptionMy { get; set; }

    }
}
