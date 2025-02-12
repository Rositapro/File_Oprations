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

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(salary))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el ID ya existe en la lista
            if (employee.Any(emp => emp.ID == id))
            {
                MessageBox.Show("El ID ya existe. Introduzca un ID único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar que el nombre no contenga números
            if (name.Any(char.IsDigit)) // Verifica si el nombre contiene números
            {
                MessageBox.Show("El nombre no puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Agregar el nuevo empleado si el ID es único
            employee.Add(new Employee { ID = id, Name = name, Salary = salary });

            // Actualizar la tabla
            UpdateDataGridView();

            // Limpiar los campos
            Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar archivo de empleados";
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivoSeleccionado = openFileDialog.FileName;
                    string extension = Path.GetExtension(archivoSeleccionado).ToLower();
                    bool datosCargados = false;

                    if (extension == ".txt")
                    {
                        datosCargados = CargarDesdeTxt(archivoSeleccionado);
                    }
                    else if (extension == ".xml")
                    {
                        datosCargados = CargarDesdeXml(archivoSeleccionado);
                    }
                    else if (extension == ".json")
                    {
                        datosCargados = CargarDesdeJson(archivoSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Formato de archivo no compatible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (datosCargados)
                    {
                        UpdateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("El archivo seleccionado está vacío o no contiene datos válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idBuscado = txtID.Text;
            if (string.IsNullOrWhiteSpace(idBuscado))
            {
                MessageBox.Show("Ingrese un ID para buscar.");
                return;
            }

            var empleadoEncontrado = employee.FirstOrDefault(emp => emp.ID == idBuscado);
            if (empleadoEncontrado != null)
            {
                MessageBox.Show($"Empleado encontrado: {empleadoEncontrado.ID}, {empleadoEncontrado.Name}, {empleadoEncontrado.Salary}");
            }
            else
            {
                MessageBox.Show("Empleado no encontrado.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim(); // Tomamos el ID del TextBox (si quieres eliminar por ID)

            // Validar que el campo ID no esté vacío
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Debe ingresar un ID para eliminar al empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar el empleado por ID
            var employeeToRemove = employee.FirstOrDefault(emp => emp.ID == id);

            if (employeeToRemove != null)  // Si encontramos al empleado
            {
                employee.Remove(employeeToRemove);  // Eliminarlo de la lista
                MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGridView();  // Actualizar la vista
                Clear();  // Limpiar los campos
            }
            else
            {
                MessageBox.Show("No se encontró un empleado con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            GuardarEnTxt();
            AbrirCarpeta();
        }

        private void butnSaveXml_Click(object sender, EventArgs e)
        {
            GuardarEnXml();
            AbrirCarpeta();
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            GuardarEnJson();
            AbrirCarpeta();
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
            MessageBox.Show($"Datos guardados en TXT\nUbicación: {archivoTxt}");
        }

        private void GuardarEnXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            using (TextWriter writer = new StreamWriter(archivoXml))
            {
                serializer.Serialize(writer, employee);
            }
            MessageBox.Show($"Datos guardados en XML\nUbicación: {archivoXml}");
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
        private void AbrirCarpeta()
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
