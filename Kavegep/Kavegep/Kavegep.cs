namespace Kavegep
{
    public partial class Kavegep : Form
    {
        public static int balance = 0;
        public Kavegep()
        {
            InitializeComponent();
            sugarBar.Maximum = 6;
            sugarBar.Minimum = 0;
            sugarBar.Value = 3;
            balanceTextBox.Text = balance.ToString();
        }
        private void minusBtn_Click(object sender, EventArgs e)
        {
            sugarBar.Step = -1;
            sugarBar.PerformStep();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            sugarBar.Step = 1;
            sugarBar.PerformStep();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}