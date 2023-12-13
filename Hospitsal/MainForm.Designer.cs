namespace Hospitsal
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGreedView = new System.Windows.Forms.DataGridView();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGreedView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.LightGreen;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.addToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1524, 42);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.medicationsToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.appointmentsToolStripMenuItem_Click);
            // 
            // medicationsToolStripMenuItem
            // 
            this.medicationsToolStripMenuItem.Name = "medicationsToolStripMenuItem";
            this.medicationsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.medicationsToolStripMenuItem.Text = "Medications";
            this.medicationsToolStripMenuItem.Click += new System.EventHandler(this.medicationsToolStripMenuItem_Click);
            // 
            // dataGreedView
            // 
            this.dataGreedView.AllowUserToAddRows = false;
            this.dataGreedView.AllowUserToDeleteRows = false;
            this.dataGreedView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGreedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGreedView.Location = new System.Drawing.Point(0, 43);
            this.dataGreedView.Name = "dataGreedView";
            this.dataGreedView.ReadOnly = true;
            this.dataGreedView.RowHeadersWidth = 82;
            this.dataGreedView.RowTemplate.Height = 33;
            this.dataGreedView.Size = new System.Drawing.Size(1524, 868);
            this.dataGreedView.TabIndex = 1;
            this.dataGreedView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGreedView_CellContentClick);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.medicationToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            this.appointmentToolStripMenuItem.Click += new System.EventHandler(this.appointmentToolStripMenuItem_Click);
            // 
            // medicationToolStripMenuItem
            // 
            this.medicationToolStripMenuItem.Name = "medicationToolStripMenuItem";
            this.medicationToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.medicationToolStripMenuItem.Text = "Medication";
            this.medicationToolStripMenuItem.Click += new System.EventHandler(this.medicationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1524, 909);
            this.Controls.Add(this.dataGreedView);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGreedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGreedView;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicationToolStripMenuItem;
    }
}

