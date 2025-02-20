using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Oprations
{
    public partial class FormIndex : Form
    {
        private List<Product> products = new List<Product>();
        public FormIndex()
        {
            InitializeComponent();
            dgvProduct.ColumnCount = 3;
            dgvProduct.Columns[0].Name = "ID";
            dgvProduct.Columns[1].Name = "Name";
            dgvProduct.Columns[2].Name = "Price";
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
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            products.Add(new Product { ID = id, Name = name, Price = price });
            dgvProduct.Rows.Add(id, name, price);
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
                    products.Clear();
                    dgvProduct.Rows.Clear();

                    foreach (string line in File.ReadAllLines(filePath))
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3 && int.TryParse(parts[0], out int id) && decimal.TryParse(parts[2], out decimal price))
                        {
                            Product product = new Product { ID = id, Name = parts[1], Price = price };
                            products.Add(product);
                            dgvProduct.Rows.Add(product.ID, product.Name, product.Price);
                        }
                    }
                    MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            var product = products.FirstOrDefault(p => p.ID == id);
            if (product != null)
            {
                MessageBox.Show($"Product Found: {product.Name}, Price: {product.Price}");
            }
            else
            {
                MessageBox.Show("Product not found.");
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

            var product = products.FirstOrDefault(p => p.ID == id);
            if (product != null)
            {
                products.Remove(product);
                dgvProduct.Rows.Clear();
                foreach (var p in products)
                {
                    dgvProduct.Rows.Add(p.ID, p.Name, p.Price);
                }
                MessageBox.Show("Product deleted.");
            }
            else
            {
                MessageBox.Show("ID not found.");
            }
        }

        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Data to Text File";
                saveFileDialog.FileName = "products.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var product in products)
                        {
                            writer.WriteLine($"{product.ID},{product.Name},{product.Price}");
                        }
                    }
                    MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("explorer.exe", "/select, " + filePath);
                }
            }
        }
    }
    
}

