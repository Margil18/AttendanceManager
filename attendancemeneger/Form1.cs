using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AttendanceManagerApp
{
    public partial class Form1 : Form
    {
        private List<AttendanceRecord> attendanceRecords = new List<AttendanceRecord>();

        public Form1()
        {
            InitializeComponent();
        }

        // Add Student
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                lstStudents.Items.Add(txtStudentName.Text);
                txtStudentName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter student name");
            }
        }

        // Add Subject
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                clbSubjects.Items.Add(txtSubjectName.Text);
                txtSubjectName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter subject name");
            }
        }

        // Mark Attendance
        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem == null)
            {
                MessageBox.Show("Select a student first!");
                return;
            }

            var selectedSubjects = clbSubjects.CheckedItems;
            if (selectedSubjects.Count == 0)
            {
                MessageBox.Show("Select at least one subject!");
                return;
            }

            string student = lstStudents.SelectedItem.ToString();
            string status = rbtnPresent.Checked ? "Present" : rbtnAbsent.Checked ? "Absent" : "Not Selected";
            string date = dtpDate.Value.ToShortDateString();

            if (status == "Not Selected")
            {
                MessageBox.Show("Please select Present or Absent!");
                return;
            }

            foreach (var subj in selectedSubjects)
            {
                attendanceRecords.Add(new AttendanceRecord
                {
                    Date = date,
                    Student = student,
                    Subject = subj.ToString(),
                    Status = status
                });
            }

            MessageBox.Show("Attendance marked successfully!");
        }

        // View Report
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (attendanceRecords.Count == 0)
            {
                MessageBox.Show("No attendance records yet!");
                return;
            }

            string report = string.Join(Environment.NewLine, attendanceRecords.Select(r => r.ToString()));
            MessageBox.Show(report, "Attendance Report");
        }

        // View Attendance Percentage
        private void btnViewPercentage_Click(object sender, EventArgs e)
        {
            if (attendanceRecords.Count == 0)
            {
                MessageBox.Show("No attendance records yet!");
                return;
            }

            var subjects = attendanceRecords.Select(r => r.Subject).Distinct();
            string result = "";

            foreach (var subject in subjects)
            {
                var students = attendanceRecords.Where(r => r.Subject == subject)
                                                .Select(r => r.Student)
                                                .Distinct();
                foreach (var student in students)
                {
                    var total = attendanceRecords.Count(r => r.Subject == subject && r.Student == student);
                    var present = attendanceRecords.Count(r => r.Subject == subject && r.Student == student && r.Status == "Present");
                    double percent = (double)present / total * 100;
                    result += $"{student} - {subject}: {percent:F2}% Present\n";
                }
            }

            MessageBox.Show(result, "Attendance Percentages");
        }

        private void txtSubjectName_TextChanged(object sender, EventArgs e) { }

        private void rbtnAbsent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public class AttendanceRecord
    {
        public string Date { get; set; }
        public string Student { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{Date} - {Student} - {Subject} - {Status}";
        }
    }
}
