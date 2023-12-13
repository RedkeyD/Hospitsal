using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitsal
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Specialty { get; set; }
        public int YearsOfExperience { get; set; }
        public string CategoryOfDoctor { get; set; }
    }

}
