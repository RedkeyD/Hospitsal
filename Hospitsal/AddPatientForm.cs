using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitsal
{
    public partial class AddPatientForm : Form
    {

        private int PatientID;
        private string FirstName;
        private string LastName;
        private string Gender;
        private string Address;
        private string PhoneNumber;
        private string Email;
        private DateTime DateOfBirth;

        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                PatientID = Convert.ToInt32(tbPatientID.Text);
                FirstName = tbFirstName.Text;
                LastName = tbLastName.Text;
                Gender = tbGender.Text;
                Address = tbAddress.Text;
                PhoneNumber = tbPhoneNumber.Text;
                Email = tbEmail.Text;
                DateOfBirth = DateTime.ParseExact(tbDateOfBirth.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid date, please check your inputs.");
            }
        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
