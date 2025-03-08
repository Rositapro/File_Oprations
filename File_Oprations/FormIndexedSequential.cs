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
    public partial class FormIndexedSequential : Form
    {
        private string fileStudents = "students.txt";
        private string fileIndex = "index.txt";
        private string fileScanned = "student_scanned.txt";
        private Dictionary<int, long> index = new Dictionary<int, long>();
        private Dictionary<int, string> career = new Dictionary<int, string>
        {
            {1, "Informatica"},
            {2, "Electronica"},
            {3, "Gestion Empresarial"},
            {4, "Mecanica"},
            {5, "Industrial"}
        };

        public FormIndexedSequential()
        {
            InitializeComponent();
            File.WriteAllText(fileStudents, string.Empty);
            File.WriteAllText(fileIndex, string.Empty);
            LoadIndex();
            ConfigureDataGridView();
            ConfigureComboBoxes();
        }

        private void ConfigureDataGridView()
        {
            dtgvStudent.Columns.Add("ID", "ID");
            dtgvStudent.Columns.Add("Name", "Name");
            dtgvStudent.Columns.Add("Career", "Career");
            dtgvStudent.Columns.Add("Grado", "Grado");
            dtgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigureComboBoxes()
        {
            cmbCareer.DataSource = new BindingSource(career, null);
            cmbCareer.DisplayMember = "Key";
            cmbCareer.ValueMember = "Key";

            for (int i = 1; i <= 9; i++)
            {
                cmbGrado.Items.Add(i.ToString());
            }
            cmbGrado.SelectedIndex = 0;

            cmbCarreraFiltro.DataSource = new BindingSource(career, null);
            cmbCarreraFiltro.DisplayMember = "Value";
            cmbCarreraFiltro.ValueMember = "Key";
        }

        private void LoadIndex()
        {
            index.Clear();
            if (File.Exists(fileIndex))
            {
                foreach (var linea in File.ReadAllLines(fileIndex))
                {
                    var datos = linea.Split('|');
                    if (datos.Length == 2 && int.TryParse(datos[0], out int id) && long.TryParse(datos[1], out long posicion))
                    {
                        index[id] = posicion;
                    }
                }
            }
        }

        private void SaveIndex()
        {
            using (var sw = new StreamWriter(fileIndex, false))
            {
                foreach (var kvp in index)
                {
                    sw.WriteLine($"{kvp.Key}|{kvp.Value}");
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            int careerID = (int)cmbCareer.SelectedValue;
            string grado = cmbGrado.SelectedItem.ToString();

            if (index.ContainsKey(id))
            {
                MessageBox.Show("ID already exists in the.");
                return;
            }

            using (var fs = new FileStream(fileStudents, FileMode.Append, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                long posicion = fs.Length;
                sw.WriteLine($"{id}|{name}|{careerID}|{grado}");
                index[id] = posicion;
            }

            SaveIndex();
            MessageBox.Show("Alumno agregado correctamente.");
            loadStudents();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            if (index.TryGetValue(id, out long posicion))
            {
                using (var fs = new FileStream(fileStudents, FileMode.Open, FileAccess.Read))
                using (var sr = new StreamReader(fs))
                {
                    fs.Seek(posicion, SeekOrigin.Begin);
                    var linea = sr.ReadLine();
                    var datos = linea.Split('|');
                    txtName.Text = datos[1];
                    cmbCareer.SelectedValue = int.Parse(datos[2]);
                    cmbGrado.SelectedItem = datos[3];
                }
            }
            else
            {
                MessageBox.Show("Alumno no encontrado.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            if (index.Remove(id))
            {
                SaveIndex();
                MessageBox.Show("Pupil removed from index (record still exists in file).", "Removed");
                loadStudents();
            }
            else
            {
                MessageBox.Show("ID not found.");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            loadStudents();
        }
        private void btnFilterByCareer_Click(object sender, EventArgs e)
        {
            int carreraSeleccionada = (int)cmbCarreraFiltro.SelectedValue;
            loadStudents(carreraSeleccionada);
        }
        private void loadStudents(int? careerFilter = null)
        {
            dtgvStudent.Rows.Clear();
            if (File.Exists(fileStudents))
            {
                foreach (var line in File.ReadAllLines(fileStudents))
                {
                    var data = line.Split('|');
                    if (data.Length == 4 && int.TryParse(data[2], out int CereerID))
                    {
                        if (careerFilter == null || CereerID == careerFilter)
                        {
                            string careerName = career.ContainsKey(CereerID) ? career[CereerID] : "Desconocida";
                            dtgvStudent.Rows.Add(data[0], data[1], careerName, data[3]);
                        }
                    }
                }
            }
        }


        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter(fileScanned))
            {
                foreach (DataGridViewRow row in dtgvStudent.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string id = row.Cells[0].Value.ToString();
                        string name = row.Cells[1].Value.ToString();
                        string career = row.Cells[2].Value.ToString();
                        string grado = row.Cells[3].Value.ToString();
                        sw.WriteLine($"{id}|{name}|{career}|{grado}");
                    }
                }
            }

            System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{Path.GetFullPath(fileScanned)}\"");
        }

        private void btnShowTxt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory(); // Carpeta actual del programa
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select student file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dtgvStudent.Rows.Clear();
                    string selectedFile = openFileDialog.FileName;

                    foreach (var line in File.ReadAllLines(selectedFile))
                    {
                        var data = line.Split('|');
                        if (data.Length == 4)
                        {
                            dtgvStudent.Rows.Add(data[0], data[1], data[2], data[3]);
                        }
                    }
                }
            }
        }
    }

}
