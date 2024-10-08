namespace tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 顯示背面_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true;
            ptxfront.Visible = false;
        }

        private void 顯示正面_Click(object sender, EventArgs e)
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
