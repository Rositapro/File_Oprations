namespace File_Oprations
{
    partial class FormSequential
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
            btnSaveJson = new Button();
            butnSaveXml = new Button();
            btnSaveTxt = new Button();
            btnAdd = new Button();
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtSalary = new TextBox();
            label3 = new Label();
            btnSearch = new Button();
            btnShow = new Button();
            dgvEmployee = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnSaveJson
            // 
            btnSaveJson.Location = new Point(350, 258);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(75, 23);
            btnSaveJson.TabIndex = 5;
            btnSaveJson.Text = "Save Json";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // butnSaveXml
            // 
            butnSaveXml.Location = new Point(269, 258);
            butnSaveXml.Name = "butnSaveXml";
            butnSaveXml.Size = new Size(75, 23);
            butnSaveXml.TabIndex = 4;
            butnSaveXml.Text = "Save Xml";
            butnSaveXml.UseVisualStyleBackColor = true;
            butnSaveXml.Click += butnSaveXml_Click;
            // 
            // btnSaveTxt
            // 
            btnSaveTxt.Location = new Point(188, 258);
            btnSaveTxt.Name = "btnSaveTxt";
            btnSaveTxt.Size = new Size(75, 23);
            btnSaveTxt.TabIndex = 3;
            btnSaveTxt.Text = "Save txt";
            btnSaveTxt.UseVisualStyleBackColor = true;
            btnSaveTxt.Click += btnSaveTxt_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(66, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(66, 28);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 12;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(66, 85);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(100, 23);
            txtSalary.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "Salary";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(66, 184);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(66, 155);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 16;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(183, 28);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(470, 224);
            dgvEmployee.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(66, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormSequential
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnShow);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(btnAdd);
            Controls.Add(dgvEmployee);
            Controls.Add(btnSaveJson);
            Controls.Add(butnSaveXml);
            Controls.Add(btnSaveTxt);
            Name = "FormSequential";
            Text = "FormSequential";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveJson;
        private Button butnSaveXml;
        private Button btnSaveTxt;
        private Button btnAdd;
        private TextBox txtID;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtSalary;
        private Label label3;
        private Button btnSearch;
        private Button btnShow;
        private DataGridView dgvEmployee;
        private Button btnDelete;
    }
}