using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitsal
{
    public class MedicationRepository
    {
        private string connectionString;

        public MedicationRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddMedication(Medication medication)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Medications (MedicationName, Dosage, Frequency, ReasonForMedication, PatientID, DoctorID) " +
                               "VALUES (@MedicationName, @Dosage, @Frequency, @ReasonForMedication, @PatientID, @DoctorID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MedicationName", medication.MedicationName);
                    command.Parameters.AddWithValue("@Dosage", medication.Dosage);
                    command.Parameters.AddWithValue("@Frequency", medication.Frequency);
                    command.Parameters.AddWithValue("@ReasonForMedication", medication.ReasonForMedication);
                    command.Parameters.AddWithValue("@PatientID", medication.PatientID);
                    command.Parameters.AddWithValue("@DoctorID", medication.DoctorID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Medication> GetAllMedications()
        {
            List<Medication> medications = new List<Medication>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Medications";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Medication medication = MapMedicationFromReader(reader);
                            medications.Add(medication);
                        }
                    }
                }
            }

            return medications;
        }

        private Medication MapMedicationFromReader(SqlDataReader reader)
        {
            Medication medication = new Medication
            {
                MedicationID = (int)reader["MedicationID"],
                MedicationName = reader["MedicationName"].ToString(),
                Dosage = reader["Dosage"].ToString(),
                Frequency = reader["Frequency"].ToString(),
                ReasonForMedication = reader["ReasonForMedication"].ToString(),
                PatientID = (int)reader["PatientID"],
                DoctorID = (int)reader["DoctorID"]
                // Add other properties as needed
            };

            return medication;
        }
    }
}
