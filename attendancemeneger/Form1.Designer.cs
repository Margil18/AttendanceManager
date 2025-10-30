using System.Drawing;
using System.Windows.Forms;

namespace AttendanceManagerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtStudentName;
        private TextBox txtSubjectName;
        private Button btnAddStudent;
        private Button btnAddSubject;
        private ListBox lstStudents;
        private CheckedListBox clbSubjects;
        private RadioButton rbtnPresent;
        private RadioButton rbtnAbsent;
        private DateTimePicker dtpDate;
        private Button btnMarkAttendance;
        private Button btnViewReport;
        private Button btnViewPercentage;
        private Label lblTitle;
        private Panel pnlStudents;
        private Panel pnlSubjects;
        private Panel pnlActions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtStudentName = new TextBox();
            txtSubjectName = new TextBox();
            btnAddStudent = new Button();
            btnAddSubject = new Button();
            lstStudents = new ListBox();
            clbSubjects = new CheckedListBox();
            rbtnPresent = new RadioButton();
            rbtnAbsent = new RadioButton();
            dtpDate = new DateTimePicker();
            btnMarkAttendance = new Button();
            btnViewReport = new Button();
            btnViewPercentage = new Button();
            lblTitle = new Label();
            pnlStudents = new Panel();
            lblStudents = new Label();
            pnlSubjects = new Panel();
            lblSubjects = new Label();
            pnlActions = new Panel();
            lblAttendance = new Label();
            lblDate = new Label();
            pnlStudents.SuspendLayout();
            pnlSubjects.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(10, 40);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(150, 30);
            txtStudentName.TabIndex = 1;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(10, 40);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(150, 30);
            txtSubjectName.TabIndex = 1;
            txtSubjectName.TextChanged += txtSubjectName_TextChanged;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(0, 123, 255);
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(170, 38);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(60, 30);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.BackColor = Color.FromArgb(40, 167, 69);
            btnAddSubject.FlatAppearance.BorderSize = 0;
            btnAddSubject.FlatStyle = FlatStyle.Flat;
            btnAddSubject.ForeColor = Color.White;
            btnAddSubject.Location = new Point(170, 38);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(60, 30);
            btnAddSubject.TabIndex = 2;
            btnAddSubject.Text = "Add";
            btnAddSubject.UseVisualStyleBackColor = false;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // lstStudents
            // 
            lstStudents.ItemHeight = 23;
            lstStudents.Location = new Point(10, 80);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(220, 165);
            lstStudents.TabIndex = 3;
            // 
            // clbSubjects
            // 
            clbSubjects.Location = new Point(10, 80);
            clbSubjects.Name = "clbSubjects";
            clbSubjects.Size = new Size(220, 179);
            clbSubjects.TabIndex = 3;
            // 
            // rbtnPresent
            // 
            rbtnPresent.Location = new Point(10, 50);
            rbtnPresent.Name = "rbtnPresent";
            rbtnPresent.Size = new Size(104, 24);
            rbtnPresent.TabIndex = 1;
            rbtnPresent.Text = "Present";
            // 
            // rbtnAbsent
            // 
            rbtnAbsent.Location = new Point(120, 50);
            rbtnAbsent.Name = "rbtnAbsent";
            rbtnAbsent.Size = new Size(120, 24);
            rbtnAbsent.TabIndex = 2;
            rbtnAbsent.Text = "Absent";
            rbtnAbsent.CheckedChanged += rbtnAbsent_CheckedChanged;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(20, 115);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 30);
            dtpDate.TabIndex = 4;
            // 
            // btnMarkAttendance
            // 
            btnMarkAttendance.BackColor = Color.FromArgb(255, 193, 7);
            btnMarkAttendance.FlatAppearance.BorderSize = 0;
            btnMarkAttendance.FlatStyle = FlatStyle.Flat;
            btnMarkAttendance.ForeColor = Color.Black;
            btnMarkAttendance.Location = new Point(20, 160);
            btnMarkAttendance.Name = "btnMarkAttendance";
            btnMarkAttendance.Size = new Size(220, 35);
            btnMarkAttendance.TabIndex = 5;
            btnMarkAttendance.Text = "Mark Attendance";
            btnMarkAttendance.UseVisualStyleBackColor = false;
            btnMarkAttendance.Click += btnMarkAttendance_Click;
            // 
            // btnViewReport
            // 
            btnViewReport.BackColor = Color.FromArgb(0, 123, 255);
            btnViewReport.FlatAppearance.BorderSize = 0;
            btnViewReport.FlatStyle = FlatStyle.Flat;
            btnViewReport.ForeColor = Color.White;
            btnViewReport.Location = new Point(20, 205);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(220, 35);
            btnViewReport.TabIndex = 6;
            btnViewReport.Text = "View Report";
            btnViewReport.UseVisualStyleBackColor = false;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // btnViewPercentage
            // 
            btnViewPercentage.BackColor = Color.FromArgb(23, 162, 184);
            btnViewPercentage.FlatAppearance.BorderSize = 0;
            btnViewPercentage.FlatStyle = FlatStyle.Flat;
            btnViewPercentage.ForeColor = Color.White;
            btnViewPercentage.Location = new Point(20, 250);
            btnViewPercentage.Name = "btnViewPercentage";
            btnViewPercentage.Size = new Size(220, 35);
            btnViewPercentage.TabIndex = 7;
            btnViewPercentage.Text = "View Attendance %";
            btnViewPercentage.UseVisualStyleBackColor = false;
            btnViewPercentage.Click += btnViewPercentage_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 70, 140);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(880, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Attendance Manager System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStudents
            // 
            pnlStudents.BackColor = Color.White;
            pnlStudents.BorderStyle = BorderStyle.FixedSingle;
            pnlStudents.Controls.Add(lblStudents);
            pnlStudents.Controls.Add(txtStudentName);
            pnlStudents.Controls.Add(btnAddStudent);
            pnlStudents.Controls.Add(lstStudents);
            pnlStudents.Location = new Point(20, 80);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(250, 280);
            pnlStudents.TabIndex = 1;
            // 
            // lblStudents
            // 
            lblStudents.Location = new Point(0, 0);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(100, 23);
            lblStudents.TabIndex = 0;
            // 
            // pnlSubjects
            // 
            pnlSubjects.BackColor = Color.White;
            pnlSubjects.BorderStyle = BorderStyle.FixedSingle;
            pnlSubjects.Controls.Add(lblSubjects);
            pnlSubjects.Controls.Add(txtSubjectName);
            pnlSubjects.Controls.Add(btnAddSubject);
            pnlSubjects.Controls.Add(clbSubjects);
            pnlSubjects.Location = new Point(300, 80);
            pnlSubjects.Name = "pnlSubjects";
            pnlSubjects.Size = new Size(250, 280);
            pnlSubjects.TabIndex = 2;
            // 
            // lblSubjects
            // 
            lblSubjects.Location = new Point(0, 0);
            lblSubjects.Name = "lblSubjects";
            lblSubjects.Size = new Size(100, 23);
            lblSubjects.TabIndex = 0;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.BorderStyle = BorderStyle.FixedSingle;
            pnlActions.Controls.Add(lblAttendance);
            pnlActions.Controls.Add(rbtnPresent);
            pnlActions.Controls.Add(rbtnAbsent);
            pnlActions.Controls.Add(lblDate);
            pnlActions.Controls.Add(dtpDate);
            pnlActions.Controls.Add(btnMarkAttendance);
            pnlActions.Controls.Add(btnViewReport);
            pnlActions.Controls.Add(btnViewPercentage);
            pnlActions.Location = new Point(580, 80);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(270, 295);
            pnlActions.TabIndex = 3;
            // 
            // lblAttendance
            // 
            lblAttendance.Location = new Point(0, 0);
            lblAttendance.Name = "lblAttendance";
            lblAttendance.Size = new Size(100, 23);
            lblAttendance.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(0, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 3;
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(880, 480);
            Controls.Add(lblTitle);
            Controls.Add(pnlStudents);
            Controls.Add(pnlSubjects);
            Controls.Add(pnlActions);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Attendance Manager";
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            pnlSubjects.ResumeLayout(false);
            pnlSubjects.PerformLayout();
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Label lblStudents;
        private Label lblSubjects;
        private Label lblAttendance;
        private Label lblDate;
    }
}
