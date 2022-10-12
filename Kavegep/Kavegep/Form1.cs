namespace Kavegep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cukorBar.Maximum = 6;
            cukorBar.Minimum = 0;
            cukorBar.Value = 3;
        }
        private void minusBtn_Click(object sender, EventArgs e)
        {
            cukorBar.Step = -1;
            cukorBar.PerformStep();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            cukorBar.Step = 1;
            cukorBar.PerformStep();
        }
    }
}