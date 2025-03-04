namespace File_Oprations
{
    partial class FormIndexedSequential
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearch = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            btnAdd = new Button();
            btnList = new Button();
            lstbCustomers = new ListBox();
            dtgvStudent = new DataGridView();
            cmbCareer = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbGrado = new ComboBox();
            btnDelete = new Button();
            btnFilterByCareer = new Button();
            cmbCarreraFiltro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(93, 125);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(223, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 2;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 47);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Name :";
            // 
            // txtID
            // 
            txtID.Location = new Point(63, 44);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(253, 125);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 6;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // lstbCustomers
            // 
            lstbCustomers.FormattingEnabled = true;
            lstbCustomers.ItemHeight = 15;
            lstbCustomers.Location = new Point(432, 23);
            lstbCustomers.Name = "lstbCustomers";
            lstbCustomers.Size = new Size(120, 94);
            lstbCustomers.TabIndex = 7;
            // 
            // dtgvStudent
            // 
            dtgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent.Location = new Point(12, 202);
            dtgvStudent.Name = "dtgvStudent";
            dtgvStudent.Size = new Size(540, 150);
            dtgvStudent.TabIndex = 8;
            // 
            // cmbCareer
            // 
            cmbCareer.FormattingEnabled = true;
            cmbCareer.Location = new Point(63, 73);
            cmbCareer.Name = "cmbCareer";
            cmbCareer.Size = new Size(100, 23);
            cmbCareer.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 10;
            label3.Text = "Career :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 81);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "Grado :";
            // 
            // cmbGrado
            // 
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(223, 73);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(100, 23);
            cmbGrado.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(172, 125);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFilterByCareer
            // 
            btnFilterByCareer.Location = new Point(12, 154);
            btnFilterByCareer.Name = "btnFilterByCareer";
            btnFilterByCareer.Size = new Size(75, 23);
            btnFilterByCareer.TabIndex = 14;
            btnFilterByCareer.Text = "Filter";
            btnFilterByCareer.UseVisualStyleBackColor = true;
            btnFilterByCareer.Click += btnFilterByCareer_Click;
            // 
            // cmbCarreraFiltro
            // 
            cmbCarreraFiltro.FormattingEnabled = true;
            cmbCarreraFiltro.Location = new Point(93, 155);
            cmbCarreraFiltro.Name = "cmbCarreraFiltro";
            cmbCarreraFiltro.Size = new Size(100, 23);
            cmbCarreraFiltro.TabIndex = 15;
            // 
            // FormIndexedSequential
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCarreraFiltro);
            Controls.Add(btnFilterByCareer);
            Controls.Add(btnDelete);
            Controls.Add(cmbGrado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbCareer);
            Controls.Add(dtgvStudent);
            Controls.Add(lstbCustomers);
            Controls.Add(btnList);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnSearch);
            Name = "FormIndexedSequential";
            Text = "FormIndexedSequential";
            ((System.ComponentModel.ISupportInitialize)dtgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private Button btnAdd;
        private Button btnList;
        private ListBox lstbCustomers;
        private DataGridView dtgvStudent;
        private ComboBox cmbCareer;
        private Label label3;
        private Label label4;
        private ComboBox cmbGrado;
        private Button btnDelete;
        private Button btnFilterByCareer;
        private ComboBox cmbCarreraFiltro;
    }
}