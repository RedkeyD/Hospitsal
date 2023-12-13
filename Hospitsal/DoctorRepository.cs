using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitsal
{
    public class DoctorRepository
    {
        private string connectionString;

        public DoctorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddDoctor(Doctor doctor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Doctors (FirstName, LastName, DateOfBirth, Gender, Specialty, YearsOfExperience, CategoryOfDoctor) " +
                               "VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Specialty, @YearsOfExperience, @CategoryOfDoctor)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                    command.Parameters.AddWithValue("@LastName", doctor.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", doctor.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", doctor.Gender);
                    command.Parameters.AddWithValue("@Specialty", doctor.Specialty);
                    command.Parameters.AddWithValue("@YearsOfExperience", doctor.YearsOfExperience);
                    command.Parameters.AddWithValue("@CategoryOfDoctor", doctor.CategoryOfDoctor);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Doctors";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = MapDoctorFromReader(reader);
                            doctors.Add(doctor);
                        }
                    }
                }
            }
            return doctors;
        }

        private Doctor MapDoctorFromReader(SqlDataReader reader)
        {
            Doctor doctor = new Doctor
            {
                DoctorID = (int)reader["DoctorID"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                DateOfBirth = (DateTime)reader["DateOfBirth"],
                Gender = reader["Gender"].ToString(),
                Specialty = reader["Specialty"].ToString(),
                YearsOfExperience = (int)reader["YearsOfExperience"],
                CategoryOfDoctor = reader["CategoryOfDoctor"].ToString()
                // Add other properties as needed
            };

            return doctor;
        }
    }
}
