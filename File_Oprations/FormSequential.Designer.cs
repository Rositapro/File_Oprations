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
            txtID = new TextBox();
            lblID = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblName = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            dtgvProducts = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSaveTxt = new Button();
            btnShowTxt = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(85, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(24, 30);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(24, 116);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(24, 84);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(85, 116);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(85, 80);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(85, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // dtgvProducts
            // 
            dtgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProducts.Location = new Point(397, 22);
            dtgvProducts.Name = "dtgvProducts";
            dtgvProducts.Size = new Size(240, 150);
            dtgvProducts.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(222, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(222, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveTxt
            // 
            btnSaveTxt.Location = new Point(222, 80);
            btnSaveTxt.Name = "btnSaveTxt";
            btnSaveTxt.Size = new Size(75, 23);
            btnSaveTxt.TabIndex = 11;
            btnSaveTxt.Text = "Savetxt";
            btnSaveTxt.UseVisualStyleBackColor = true;
            btnSaveTxt.Click += btnSaveTxt_Click;
            // 
            // btnShowTxt
            // 
            btnShowTxt.Location = new Point(222, 108);
            btnShowTxt.Name = "btnShowTxt";
            btnShowTxt.Size = new Size(75, 23);
            btnShowTxt.TabIndex = 12;
            btnShowTxt.Text = "Show";
            btnShowTxt.UseVisualStyleBackColor = true;
            btnShowTxt.Click += btnShowTxt_Click;
            // 
            // FormSequential
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowTxt);
            Controls.Add(btnSaveTxt);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dtgvProducts);
            Controls.Add(txtName);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblName);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Name = "FormSequential";
            Text = "FormSequential";
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label lblID;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblName;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtName;
        private DataGridView dtgvProducts;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSaveTxt;
        private Button btnShowTxt;
    }
}