using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace File_Oprations
{
    public partial class FormSequential : Form 
    {
        private string carpetaDestino = Path.Combine(Application.StartupPath, "DatosEmpleados");
        private string? archivoTxt, archivoXml, archivoJson;
        private List<Employee> employee = new List<Employee>();
        public FormSequential()
        {
            InitializeComponent();
            ConfigurarRutas();
            ConfigurarDataGridView();
            Directory.CreateDirectory(carpetaDestino);
        }
        private void ConfigurarRutas()
        {
            archivoTxt = Path.Combine(carpetaDestino, "employee.txt");
            archivoXml = Path.Combine(carpetaDestino, "employee.xml");
            archivoJson = Path.Combine(carpetaDestino, "employee.json");
        }
        private void ConfigurarDataGridView()
        {
            dgvEmployee.ColumnCount = 3;
            dgvEmployee.Columns[0].Name = "ID";
            dgvEmployee.Columns[1].Name = "Name";
            dgvEmployee.Columns[2].Name = "Salary";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            string salary = txtSalary.Text.Trim();
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(salary))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (employee.Any(emp => emp.ID == id))
            {
                MessageBox.Show("The ID already exists. Enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            if (name.Any(char.IsDigit)) 
            {
                MessageBox.Show("The name cannot contain numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            employee.Add(new Employee { ID = id, Name = name, Salary = salary });

            UpdateDataGridView();
            Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select employee file";
                openFileDialog.Filter = "Todos los archivos compatibles (*.txt;*.xml;*.json)|*.txt;*.xml;*.json|Archivos de texto (*.txt)|*.txt|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivoSeleccionado = openFileDialog.FileName;
                    string extension = Path.GetExtension(archivoSeleccionado).ToLower();
                    bool dataLoaded = false;

                    if (extension == ".txt")
                    {
                        dataLoaded = CargarDesdeTxt(archivoSeleccionado);
                    }
                    else if (extension == ".xml")
                    {
                        dataLoaded = CargarDesdeXml(archivoSeleccionado);
                    }
                    else if (extension == ".json")
                    {
                        dataLoaded = CargarDesdeJson(archivoSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Unsupported file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dataLoaded)
                    {
                        UpdateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("The selected file is empty or does not contain valid data.", "Wearing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idBuscado = txtID.Text;
            if (string.IsNullOrWhiteSpace(idBuscado))
            {
                MessageBox.Show("Enter an ID to search.");
                return;
            }

            var empleadoEncontrado = employee.FirstOrDefault(emp => emp.ID == idBuscado);
            if (empleadoEncontrado != null)
            {
                MessageBox.Show($"Employee found: {empleadoEncontrado.ID}, {empleadoEncontrado.Name}, {empleadoEncontrado.Salary}");
            }
            else
            {
                MessageBox.Show("Employee not found.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("You must enter an ID to delete the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var employeeToRemove = employee.FirstOrDefault(emp => emp.ID == id);

            if (employeeToRemove != null) 
            {
                employee.Remove(employeeToRemove);
                MessageBox.Show("Employee successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGridView(); 
                Clear();  
            }
            else
            {
                MessageBox.Show("An employee with that ID was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            GuardarEnTxt();
            OpenFplder();
        }

        private void butnSaveXml_Click(object sender, EventArgs e)
        {
            GuardarEnXml();
            OpenFplder();
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            GuardarEnJson();
            OpenFplder();
        }
        private void GuardarEnTxt()
        {

            using (StreamWriter sw = new StreamWriter(archivoTxt))
            {
                foreach (var emp in employee)
                {
                    sw.WriteLine($"{emp.ID},{emp.Name},{emp.Salary}");
                }
            }
            MessageBox.Show($"Data saved in TXT\nUbicación: {archivoTxt}");
        }

        private void GuardarEnXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            using (TextWriter writer = new StreamWriter(archivoXml))
            {
                serializer.Serialize(writer, employee);
            }
            MessageBox.Show($"Data saved in XML\nUbicación: {archivoXml}");
        }

        private void GuardarEnJson()
        {
            string json = JsonSerializer.Serialize(employee, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivoJson, json);
            MessageBox.Show($"Datos guardados en JSON\nUbicación: {archivoJson}");
        }
        private bool CargarDesdeTxt(string archivo)
        {
            if (!File.Exists(archivo) || new FileInfo(archivo).Length == 0)
                return false;

            string[] lineas = File.ReadAllLines(archivo);
            employee.Clear();

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                if (datos.Length == 3)
                {
                    employee.Add(new Employee { ID = datos[0], Name = datos[1], Salary = datos[2] });
                }
            }

            return employee.Count > 0;
        }

        private bool CargarDesdeXml(string archivo)
        {
            if (!File.Exists(archivo) || new FileInfo(archivo).Length == 0)
                return false;

            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            using (TextReader reader = new StreamReader(archivo))
            {
                employee = (List<Employee>)serializer.Deserialize(reader);
            }

            return employee.Count > 0;
        }

        private bool CargarDesdeJson(string archivo)
        {
            if (!File.Exists(archivo) || new FileInfo(archivo).Length == 0)
                return false;

            string json = File.ReadAllText(archivo);
            employee = JsonSerializer.Deserialize<List<Employee>>(json);

            return employee.Count > 0;
        }
        private void OpenFplder()
        {
            Process.Start("explorer.exe", carpetaDestino);
        }
        private void UpdateDataGridView()
        {
            dgvEmployee.Rows.Clear();
            foreach (var emp in employee)
            {
                dgvEmployee.Rows.Add(emp.ID, emp.Name, emp.Salary);
            }
        }

        private void Clear()
        {
            txtID.Clear();
            txtName.Clear();
            txtSalary.Clear();
        }

       
    }
}
