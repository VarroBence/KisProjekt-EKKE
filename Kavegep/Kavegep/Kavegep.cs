namespace Kavegep
{
    public partial class Kavegep : Form
    {
        private static int balance = 0; //Nem tudom hogy ez korrekt e �gy
        public Kavegep()
        {
            InitializeComponent();
            sugarBar.Maximum = 4;
            sugarBar.Minimum = 0;
            sugarBar.Value = 2;
            balanceTextBox.Text = balance.ToString() + " Ft"; //Ha v�ltoztatod a balance-ot rakj egy ilyet ut�na
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
    }
}