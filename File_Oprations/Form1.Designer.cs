namespace File_Oprations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileSystemWatcher1 = new FileSystemWatcher();
            btnSequentialForm = new Button();
            btnIndex = new Button();
            btnDirectAccess = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnSequentialForm
            // 
            btnSequentialForm.Location = new Point(80, 122);
            btnSequentialForm.Name = "btnSequentialForm";
            btnSequentialForm.Size = new Size(140, 23);
            btnSequentialForm.TabIndex = 0;
            btnSequentialForm.Text = "Sequential";
            btnSequentialForm.UseVisualStyleBackColor = true;
            btnSequentialForm.Click += btnSequentialForm_Click;
            // 
            // btnIndex
            // 
            btnIndex.Location = new Point(80, 151);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new Size(140, 23);
            btnIndex.TabIndex = 1;
            btnIndex.Text = "Index Sequential";
            btnIndex.UseVisualStyleBackColor = true;
            btnIndex.Click += btnIndex_Click;
            // 
            // btnDirectAccess
            // 
            btnDirectAccess.Location = new Point(80, 180);
            btnDirectAccess.Name = "btnDirectAccess";
            btnDirectAccess.Size = new Size(140, 23);
            btnDirectAccess.TabIndex = 2;
            btnDirectAccess.Text = "DirectAccess";
            btnDirectAccess.UseVisualStyleBackColor = true;
            btnDirectAccess.Click += btnDirectAccess_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 90);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 291);
            Controls.Add(label1);
            Controls.Add(btnDirectAccess);
            Controls.Add(btnIndex);
            Controls.Add(btnSequentialForm);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button btnDirectAccess;
        private Button btnIndex;
        private Button btnSequentialForm;
        private Label label1;
    }
}
