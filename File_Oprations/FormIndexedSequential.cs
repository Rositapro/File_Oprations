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
        private string archivoAlumnos = "alumnos.txt";
        private string archivoIndice = "indice.txt";
        private Dictionary<int, long> indice = new Dictionary<int, long>();
        private Dictionary<int, string> carreras = new Dictionary<int, string>
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
            CargarIndice();
            ConfigurarDataGridView();
            ConfigurarComboBoxes();
        }

        private void ConfigurarDataGridView()
        {
            dtgvStudent.Columns.Add("ID", "ID");
            dtgvStudent.Columns.Add("Nombre", "Nombre");
            dtgvStudent.Columns.Add("Carrera", "Carrera");
            dtgvStudent.Columns.Add("Grado", "Grado");
            dtgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigurarComboBoxes()
        {
            cmbCareer.DataSource = new BindingSource(carreras, null);
            cmbCareer.DisplayMember = "Value";
            cmbCareer.ValueMember = "Key";

            for (int i = 1; i <= 9; i++)
            {
                cmbGrado.Items.Add(i.ToString());
            }
            cmbGrado.SelectedIndex = 0;
        }

        private void CargarIndice()
        {
            indice.Clear();
            if (File.Exists(archivoIndice))
            {
                foreach (var linea in File.ReadAllLines(archivoIndice))
                {
                    var datos = linea.Split('|');
                    if (datos.Length == 2 && int.TryParse(datos[0], out int id) && long.TryParse(datos[1], out long posicion))
                    {
                        indice[id] = posicion;
                    }
                }
            }
        }

        private void GuardarIndice()
        {
            using (var sw = new StreamWriter(archivoIndice, false))
            {
                foreach (var kvp in indice)
                {
                    sw.WriteLine($"{kvp.Key}|{kvp.Value}");
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtName.Text;
            int carreraId = (int)cmbCareer.SelectedValue;
            string grado = cmbGrado.SelectedItem.ToString();

            if (indice.ContainsKey(id))
            {
                MessageBox.Show("ID ya existe en el archivo.");
                return;
            }

            using (var fs = new FileStream(archivoAlumnos, FileMode.Append, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                long posicion = fs.Length;
                sw.WriteLine($"{id}|{nombre}|{carreraId}|{grado}");
                indice[id] = posicion;
            }

            GuardarIndice();
            MessageBox.Show("Alumno agregado correctamente.");
            CargarAlumnos();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            if (indice.TryGetValue(id, out long posicion))
            {
                using (var fs = new FileStream(archivoAlumnos, FileMode.Open, FileAccess.Read))
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
        private void btnList_Click(object sender, EventArgs e)
        {
            CargarAlumnos();
        }
        private void btnFilterByCareer_Click(object sender, EventArgs e)
        {
            int carreraId = (int)cmbCareer.SelectedValue;
            CargarAlumnos(carreraId);
        }
        private void CargarAlumnos(int? carreraFiltro = null)
        {
            dtgvStudent.Rows.Clear();
            if (File.Exists(archivoAlumnos))
            {
                foreach (var linea in File.ReadAllLines(archivoAlumnos))
                {
                    var datos = linea.Split('|');
                    if (datos.Length == 4 && int.TryParse(datos[2], out int carreraId))
                    {
                        if (carreraFiltro == null || carreraId == carreraFiltro)
                        {
                            string carreraNombre = carreras.ContainsKey(carreraId) ? carreras[carreraId] : "Desconocida";
                            dtgvStudent.Rows.Add(datos[0], datos[1], carreraNombre, datos[3]);
                        }
                    }
                }
            }
        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            if (indice.Remove(id))
            {
                GuardarIndice();
                MessageBox.Show("Alumno eliminado del índice (registro aún existe en archivo).", "Eliminado");
                CargarAlumnos();
            }
            else
            {
                MessageBox.Show("ID no encontrado.");
            }
        }
    }
}
