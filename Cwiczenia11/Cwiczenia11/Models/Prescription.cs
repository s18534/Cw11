using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class Prescription
    {
        public Prescription()
        {
            Prescription_Medicament = new HashSet<Prescription_Medicament>();
        }

        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
           
        public virtual Doctor IdDoctorMy { get; set; }
        public virtual Patient IdPatientMy { get; set; }
        public ICollection<Prescription_Medicament> Prescription_Medicament { get; set; }

    }
}
