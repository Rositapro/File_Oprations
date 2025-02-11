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
            dgvSequentialStudents = new DataGridView();
            btnAdd = new Button();
            txtName = new TextBox();
            cmbCareer = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSequentialStudents).BeginInit();
            SuspendLayout();
            // 
            // btnSaveJson
            // 
            btnSaveJson.Location = new Point(606, 324);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(75, 23);
            btnSaveJson.TabIndex = 5;
            btnSaveJson.Text = "Save Json";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // butnSaveXml
            // 
            butnSaveXml.Location = new Point(525, 324);
            butnSaveXml.Name = "butnSaveXml";
            butnSaveXml.Size = new Size(75, 23);
            butnSaveXml.TabIndex = 4;
            butnSaveXml.Text = "Save Xml";
            butnSaveXml.UseVisualStyleBackColor = true;
            butnSaveXml.Click += butnSaveXml_Click;
            // 
            // btnSaveTxt
            // 
            btnSaveTxt.Location = new Point(444, 324);
            btnSaveTxt.Name = "btnSaveTxt";
            btnSaveTxt.Size = new Size(75, 23);
            btnSaveTxt.TabIndex = 3;
            btnSaveTxt.Text = "Save txt";
            btnSaveTxt.UseVisualStyleBackColor = true;
            btnSaveTxt.Click += btnSaveTxt_Click;
            // 
            // dgvSequentialStudents
            // 
            dgvSequentialStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSequentialStudents.Location = new Point(384, 108);
            dgvSequentialStudents.Name = "dgvSequentialStudents";
            dgvSequentialStudents.Size = new Size(240, 150);
            dgvSequentialStudents.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(112, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 8;
            // 
            // cmbCareer
            // 
            cmbCareer.FormattingEnabled = true;
            cmbCareer.Location = new Point(66, 64);
            cmbCareer.Name = "cmbCareer";
            cmbCareer.Size = new Size(121, 23);
            cmbCareer.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 11;
            label2.Text = "Career";
            // 
            // FormSequential
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCareer);
            Controls.Add(txtName);
            Controls.Add(btnAdd);
            Controls.Add(dgvSequentialStudents);
            Controls.Add(btnSaveJson);
            Controls.Add(butnSaveXml);
            Controls.Add(btnSaveTxt);
            Name = "FormSequential";
            Text = "FormSequential";
            ((System.ComponentModel.ISupportInitialize)dgvSequentialStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveJson;
        private Button butnSaveXml;
        private Button btnSaveTxt;
        private DataGridView dgvSequentialStudents;
        private Button btnAdd;
        private TextBox txtName;
        private ComboBox cmbCareer;
        private Label label1;
        private Label label2;
    }
}