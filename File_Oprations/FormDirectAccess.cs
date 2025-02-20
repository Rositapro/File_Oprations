using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Oprations
{
    public partial class FormDirectAccess : Form
    {
        private List<Student> students = new List<Student>();

        public FormDirectAccess()
        {
            InitializeComponent();
            dgvStudents.ColumnCount = 3;
            dgvStudents.Columns[0].Name = "ID";
            dgvStudents.Columns[1].Name = "Name";
            dgvStudents.Columns[2].Name = "Age";
        }
        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            var student = students.FirstOrDefault(s => s.ID == id);
            if (student != null)
            {
                students.Remove(student);
                dgvStudents.Rows.Clear();
                foreach (var s in students)
                {
                    dgvStudents.Rows.Add(s.ID, s.Name, s.Age);
                }
                MessageBox.Show("Student deleted.");
            }
            else
            {
                MessageBox.Show("ID not found.");
            }
        }
        private void butnSaveXml_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }
            string name = txtName.Text;
            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Invalid age format.");
                return;
            }

            students.Add(new Student { ID = id, Name = name, Age = age });
            dgvStudents.Rows.Add(id, name, age);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            var student = students.FirstOrDefault(s => s.ID == id);
            if (student != null)
            {
                MessageBox.Show($"Student Found: {student.Name}, Age: {student.Age}");
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            var student = students.FirstOrDefault(s => s.ID == id);
            if (student != null)
            {
                students.Remove(student);
                dgvStudents.Rows.Clear();
                foreach (var s in students)
                {
                    dgvStudents.Rows.Add(s.ID, s.Name, s.Age);
                }
                MessageBox.Show("Student deleted.");
            }
            else
            {
                MessageBox.Show("ID not found.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Open Data File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    students.Clear();
                    dgvStudents.Rows.Clear();

                    foreach (string line in File.ReadAllLines(filePath))
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3 && int.TryParse(parts[0], out int id) && int.TryParse(parts[2], out int age))
                        {
                            Student student = new Student { ID = id, Name = parts[1], Age = age };
                            students.Add(student);
                            dgvStudents.Rows.Add(student.ID, student.Name, student.Age);
                        }
                    }
                    MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
