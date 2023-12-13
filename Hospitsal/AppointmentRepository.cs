using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitsal
{
    public class AppointmentRepository
    {
        private string connectionString;

        public AppointmentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddAppointment(Appointment appointment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentTime, ReasonForVisit, Diagnosis, CostOfTreatment) " +
                               "VALUES (@PatientID, @DoctorID, @AppointmentDate, @AppointmentTime, @ReasonForVisit, @Diagnosis, @CostOfTreatment)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                    command.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                    command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    command.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);
                    command.Parameters.AddWithValue("@ReasonForVisit", appointment.ReasonForVisit);
                    command.Parameters.AddWithValue("@Diagnosis", appointment.Diagnosis);
                    command.Parameters.AddWithValue("@CostOfTreatment", appointment.CostOfTreatment);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Appointments";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = MapAppointmentFromReader(reader);
                            appointments.Add(appointment);
                        }
                    }
                }
            }

            return appointments;
        }

        private Appointment MapAppointmentFromReader(SqlDataReader reader)
        {
            Appointment appointment = new Appointment
            {
                AppointmentID = (int)reader["AppointmentID"],
                PatientID = (int)reader["PatientID"],
                DoctorID = (int)reader["DoctorID"],
                AppointmentDate = (DateTime)reader["AppointmentDate"],
                AppointmentTime = (TimeSpan)reader["AppointmentTime"],
                ReasonForVisit = reader["ReasonForVisit"].ToString(),
                Diagnosis = reader["Diagnosis"].ToString(),
                CostOfTreatment = (decimal)reader["CostOfTreatment"]
                // Add other properties as needed
            };

            return appointment;
        }
    }
}
