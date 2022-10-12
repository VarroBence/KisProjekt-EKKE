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
            cukorBar.Step = -1;
            cukorBar.PerformStep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cukorBar.Step = 1;
            cukorBar.PerformStep();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}