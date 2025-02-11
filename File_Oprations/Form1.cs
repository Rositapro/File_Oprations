namespace File_Oprations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSequentialForm_Click(object sender, EventArgs e)
        {
            FormSequential seqForm = new FormSequential();
            seqForm.Show();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            FormIndex idxForm = new FormIndex();
            idxForm.Show();
        }

        private void btnDirectAccess_Click(object sender, EventArgs e)
        {
            FormDirectAccess dirForm = new FormDirectAccess();
            dirForm.Show();
        }
    }
}
