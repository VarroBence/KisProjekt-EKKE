namespace Kavegep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 6;
            progressBar1.Minimum = 0;
            progressBar1.Value = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Step = -1;
            progressBar1.PerformStep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            progressBar1.PerformStep();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}