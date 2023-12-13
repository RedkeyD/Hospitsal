using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitsal
{
    public partial class MainForm : Form
    {

        private DoctorRepository doctorRepository;
        private BindingSource doctorBindingSource;

        private PatientRepository patientRepository;
        private BindingSource patientBindingSource;

        private AppointmentRepository appointmentRepository;
        private BindingSource appointmentBindingSource;

        private MedicationRepository medicationRepository;
        private BindingSource medicationBindingSource;

        private string connectionString = "Data Source = LAPTOP-AOV61HTP\\SQLEXPRESS;Initial Catalog = Hospital;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGreedView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorRepository = new DoctorRepository(connectionString);
            doctorBindingSource = new BindingSource();
            dataGreedView.DataSource = doctorBindingSource;

            List<Doctor> doctors = doctorRepository.GetAllDoctors(); 
            doctorBindingSource.DataSource = doctors;
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientRepository = new PatientRepository(connectionString);
            patientBindingSource = new BindingSource();
            dataGreedView.DataSource = patientBindingSource;

            List<Patient> patients = patientRepository.GetAllPatients();
            patientBindingSource.DataSource = patients;
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appointmentRepository = new AppointmentRepository(connectionString);
            appointmentBindingSource = new BindingSource();
            dataGreedView.DataSource = appointmentBindingSource;

            List<Appointment> appointments = appointmentRepository.GetAllAppointments();
            appointmentBindingSource.DataSource = appointments;
        }

        private void medicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicationRepository = new MedicationRepository(connectionString);
            medicationBindingSource = new BindingSource();
            dataGreedView.DataSource = medicationBindingSource;

            List<Medication> medications = medicationRepository.GetAllMedications();
            medicationBindingSource.DataSource = medications;
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientForm form = new AddPatientForm();
            form.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctorForm form = new AddDoctorForm();
            form.Show();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAppointmentForm form = new AddAppointmentForm();
            form.Show();
        }

        private void medicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicationForm form = new AddMedicationForm();
            form.Show();
        }
    }
}
