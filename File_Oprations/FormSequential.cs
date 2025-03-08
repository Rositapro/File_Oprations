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
    public partial class FormSequential : Form
    {
        public FormSequential()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }
        private void ConfigureDataGridView()
        {
            dtgvProducts.Columns.Add("ID", "ID");
            dtgvProducts.Columns.Add("Name", "Name");
            dtgvProducts.Columns.Add("Quantity", "Quantity");
            dtgvProducts.Columns.Add("Price", "Price");
            dtgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
              string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(txtID.Text, out int id) || !int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid input. Please enter correct values.");
                return;
            }

            foreach (DataGridViewRow row in dtgvProducts.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString() == id.ToString())
                {
                    MessageBox.Show("This ID already exists.");
                    return;
                }
            }
            Product product = new Product(id, txtName.Text, quantity, price);
            dtgvProducts.Rows.Add(product.ID, product.Name, product.Quantity, product.Price);
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvProducts.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvProducts.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dtgvProducts.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Products";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        foreach (DataGridViewRow row in dtgvProducts.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                Product product = new Product(
                                    Convert.ToInt32(row.Cells[0].Value),
                                    row.Cells[1].Value.ToString(),
                                    Convert.ToInt32(row.Cells[2].Value),
                                    Convert.ToDecimal(row.Cells[3].Value)
                                );
                                sw.WriteLine(product.ToString());
                            }
                        }
                    }
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{filePath}\"");
                }
            }
        }

        private void btnShowTxt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Select Product File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dtgvProducts.Rows.Clear();
                    string selectedFile = openFileDialog.FileName;

                    foreach (var line in File.ReadAllLines(selectedFile))
                    {
                        Product product = Product.FromString(line);
                        if (product != null)
                        {
                            dtgvProducts.Rows.Add(product.ID, product.Name, product.Quantity, product.Price);
                        }
                    }
                }
            }
        }
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }
    }
}
