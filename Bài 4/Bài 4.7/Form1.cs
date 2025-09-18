namespace Bài_4._7
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
            long S = 1;
            for (int i = 1; i <= n; i++)
                S *= i;
            txtS.Text = S.ToString();
        }
    }
}
