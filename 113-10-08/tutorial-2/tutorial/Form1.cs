namespace tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ��ܭI��_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true;
            ptxfront.Visible = false;
        }

        private void ��ܥ���_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
