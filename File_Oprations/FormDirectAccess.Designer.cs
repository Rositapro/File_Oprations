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
            dgvDirectAccessStudents = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            cmbCareer = new ComboBox();
            txtName = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDirectAccessStudents).BeginInit();
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
            // dgvDirectAccessStudents
            // 
            dgvDirectAccessStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirectAccessStudents.Location = new Point(280, 150);
            dgvDirectAccessStudents.Name = "dgvDirectAccessStudents";
            dgvDirectAccessStudents.Size = new Size(240, 150);
            dgvDirectAccessStudents.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 51);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 16;
            label2.Text = "Career";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // cmbCareer
            // 
            cmbCareer.FormattingEnabled = true;
            cmbCareer.Location = new Point(65, 51);
            cmbCareer.Name = "cmbCareer";
            cmbCareer.Size = new Size(121, 23);
            cmbCareer.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Location = new Point(65, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(111, 95);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // FormDirectAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCareer);
            Controls.Add(txtName);
            Controls.Add(btnAdd);
            Controls.Add(dgvDirectAccessStudents);
            Controls.Add(btnSaveJson);
            Controls.Add(butnSaveXml);
            Controls.Add(btnSaveTxt);
            Name = "FormDirectAccess";
            Text = "FormDirectAccess";
            ((System.ComponentModel.ISupportInitialize)dgvDirectAccessStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveTxt;
        private Button butnSaveXml;
        private Button btnSaveJson;
        private DataGridView dgvDirectAccessStudents;
        private Label label2;
        private Label label1;
        private ComboBox cmbCareer;
        private TextBox txtName;
        private Button btnAdd;
    }
}