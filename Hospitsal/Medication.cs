using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitsal
{
    public class Medication
    {
        public int MedicationID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string ReasonForMedication { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
    }
}
