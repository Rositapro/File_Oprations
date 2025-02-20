namespace File_Oprations
{
    partial class FormDirectAccess
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
            btnSaveTxt = new Button();
            butnSaveXml = new Button();
            btnSaveJson = new Button();
            dgvStudents = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            btnAdd = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnShow = new Button();
            txtName = new TextBox();
            txtAge = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnSaveTxt
            // 
            btnSaveTxt.Location = new Point(215, 319);
            btnSaveTxt.Name = "btnSaveTxt";
            btnSaveTxt.Size = new Size(75, 23);
            btnSaveTxt.TabIndex = 0;
            btnSaveTxt.Text = "Save txt";
            btnSaveTxt.UseVisualStyleBackColor = true;
            btnSaveTxt.Click += btnSaveTxt_Click;
            // 
            // butnSaveXml
            // 
            butnSaveXml.Location = new Point(296, 319);
            butnSaveXml.Name = "butnSaveXml";
            butnSaveXml.Size = new Size(75, 23);
            butnSaveXml.TabIndex = 1;
            butnSaveXml.Text = "Save Xml";
            butnSaveXml.UseVisualStyleBackColor = true;
            butnSaveXml.Click += butnSaveXml_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Location = new Point(377, 319);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(75, 23);
            btnSaveJson.TabIndex = 2;
            btnSaveJson.Text = "Save Json";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(224, 15);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(365, 150);
            dgvStudents.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 76);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 43);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(70, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(115, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(115, 209);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(115, 238);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(115, 267);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 19;
            btnShow.Text = "show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 20;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(70, 98);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 106);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 22;
            label3.Text = "Age";
            // 
            // FormDirectAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(btnShow);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(btnAdd);
            Controls.Add(dgvStudents);
            Controls.Add(btnSaveJson);
            Controls.Add(butnSaveXml);
            Controls.Add(btnSaveTxt);
            Name = "FormDirectAccess";
            Text = "FormDirectAccess";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveTxt;
        private Button butnSaveXml;
        private Button btnSaveJson;
        private DataGridView dgvStudents;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnShow;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label3;
    }
}