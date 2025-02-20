namespace File_Oprations
{
    partial class FormIndex
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
            btnDelete = new Button();
            btnShow = new Button();
            btnSearch = new Button();
            label3 = new Label();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            btnSaveTxt = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(60, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(60, 172);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 30;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(60, 201);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 28;
            label3.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(60, 102);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 25;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 24;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(60, 45);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(60, 143);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(177, 45);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.Size = new Size(470, 224);
            dgvProduct.TabIndex = 21;
            // 
            // btnSaveTxt
            // 
            btnSaveTxt.Location = new Point(182, 275);
            btnSaveTxt.Name = "btnSaveTxt";
            btnSaveTxt.Size = new Size(75, 23);
            btnSaveTxt.TabIndex = 18;
            btnSaveTxt.Text = "Save txt";
            btnSaveTxt.UseVisualStyleBackColor = true;
            btnSaveTxt.Click += btnSaveTxt_Click;
            // 
            // FormIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnShow);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(btnAdd);
            Controls.Add(dgvProduct);
            Controls.Add(btnSaveTxt);
            Name = "FormIndex";
            Text = "FormIndex";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnShow;
        private Button btnSearch;
        private Label label3;
        private TextBox txtPrice;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private Button btnAdd;
        private DataGridView dgvProduct;
        private Button btnSaveTxt;
    }
}