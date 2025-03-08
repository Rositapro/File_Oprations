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
        private string filePath = "students.dat";
        private List<Student> students = new List<Student>();

        public FormDirectAccess()
        {
            InitializeComponent();
            dgvStudents.ColumnCount = 3;
            dgvStudents.Columns[0].Name = "ID";
            dgvStudents.Columns[1].Name = "Name";
            dgvStudents.Columns[2].Name = "Age";

            LoadData();
        }
        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    students.Clear();
                    dgvStudents.Rows.Clear();
                    while (fs.Position < fs.Length)
                    {
                        var student = Student.ReadFromBinary(reader);
                        students.Add(student);
                        dgvStudents.Rows.Add(student.ID, student.Name, student.Age);
                    }
                }
            }
        }
        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string exportPath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(exportPath))
                    {
                        foreach (var student in students)
                        {
                            writer.WriteLine($"{student.ID},{student.Name},{student.Age}");
                        }
                    }
                    MessageBox.Show($"Data saved to {exportPath}");
                }
            }
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
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                Student student = new Student { ID = id, Name = name, Age = age };
                student.WriteToBinary(writer);
            }
            dgvStudents.Rows.Add(id, name, age);
            students.Add(new Student { ID = id, Name = name, Age = age });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                bool found = false;
                while (fs.Position < fs.Length)
                {
                    var student = Student.ReadFromBinary(reader);
                    if (student.ID == id)
                    {
                        MessageBox.Show($"Student Found: {student.Name}, Age: {student.Age}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Student not found.");
                }
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
            students.RemoveAll(s => s.ID == id);
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                foreach (var student in students)
                {
                    student.WriteToBinary(writer);
                }
            }

            dgvStudents.Rows.Clear();
            foreach (var student in students)
            {
                dgvStudents.Rows.Add(student.ID, student.Name, student.Age);
            }
            MessageBox.Show("Student deleted.");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Binary Files (*.dat)|*.dat|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    LoadData();
                    MessageBox.Show("Data loaded from binary file.");
                }
            }
        }
    }
}
