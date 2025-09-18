namespace Bài_4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            double S = 0;
            for (int i = 0; i <= n; i++)
                S += 1.0 / (2 * i + 1);
            txtS.Text = S.ToString();
        }
    }
}
