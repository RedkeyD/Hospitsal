using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitsal
{
    public class PatientRepository
    {
        private string connectionString;

        public PatientRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddPatient(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, Address, PhoneNumber, Email) " +
                               "VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Address, @PhoneNumber, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@LastName", patient.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@Address", patient.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", patient.Email);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Patients";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = MapPatientFromReader(reader);
                            patients.Add(patient);
                        }
                    }
                }
            }

            return patients;
        }

        private Patient MapPatientFromReader(SqlDataReader reader)
        {
            Patient patient = new Patient
            {
                PatientID = (int)reader["PatientID"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                DateOfBirth = (DateTime)reader["DateOfBirth"],
                Gender = reader["Gender"].ToString(),
                Address = reader["Address"].ToString(),
                PhoneNumber = reader["PhoneNumber"].ToString(),
                Email = reader["Email"].ToString()
            };

            return patient;
        }
    }
}
