namespace Bài_4_1
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
            int S = 0;
            for (int i = 1; i <= n; i++)
                S += i;
            txtS.Text = S.ToString();
        }
    }
}
