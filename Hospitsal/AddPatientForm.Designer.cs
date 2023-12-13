namespace Hospitsal
{
    partial class AddPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPatientID = new System.Windows.Forms.TextBox();
            this.tbDateOfBirth = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PatientID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "PhoneNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "LastName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "DateOfBirth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(155, 103);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(322, 31);
            this.tbFirstName.TabIndex = 8;
            this.tbFirstName.Text = "Kiril";
            // 
            // tbPatientID
            // 
            this.tbPatientID.Location = new System.Drawing.Point(155, 218);
            this.tbPatientID.Name = "tbPatientID";
            this.tbPatientID.Size = new System.Drawing.Size(322, 31);
            this.tbPatientID.TabIndex = 9;
            this.tbPatientID.Text = "11";
            // 
            // tbDateOfBirth
            // 
            this.tbDateOfBirth.Location = new System.Drawing.Point(155, 346);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.Size = new System.Drawing.Size(322, 31);
            this.tbDateOfBirth.TabIndex = 10;
            this.tbDateOfBirth.Text = "23.11.200";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(155, 445);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(322, 31);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.Text = "Cmirnov@gmail.com";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(769, 97);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(322, 31);
            this.tbLastName.TabIndex = 12;
            this.tbLastName.Text = "Cmirnov";
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(769, 224);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(322, 31);
            this.tbGender.TabIndex = 13;
            this.tbGender.Text = "male";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(769, 346);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(322, 31);
            this.tbAddress.TabIndex = 14;
            this.tbAddress.Text = "Ioshkar-Ola";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(769, 448);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(322, 31);
            this.tbPhoneNumber.TabIndex = 15;
            this.tbPhoneNumber.Text = "+79889764545";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(493, 510);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(208, 65);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1174, 599);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDateOfBirth);
            this.Controls.Add(this.tbPatientID);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPatientForm";
            this.Text = "Ioshkar-Ola";
            this.Load += new System.EventHandler(this.AddPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPatientID;
        private System.Windows.Forms.TextBox tbDateOfBirth;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Button saveButton;
    }
}