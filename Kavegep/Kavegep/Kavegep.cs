namespace Kavegep
{
    public partial class Kavegep : Form
    {
        #region Árak fixálása
        private int balance = 0; //Nem tudom hogy ez korrekt e így
        private int total = 0;
        private int elozoAr = 0;
        private int pressoAr = 250;
        private int hosszuKaveAr = 300;
        private int ristAr = 200;
        private int americanoAr = 350;
        private int teaAr = 150;
        private int tejAr = 50;
        #endregion

        public Kavegep()
        {
            InitializeComponent();
            sugarBar.Maximum = 4;
            sugarBar.Minimum = 0;
            sugarBar.Value = 2;
            balanceTextBox.Text = balance.ToString() + " Ft"; //Ha változtatod a balance-ot rakj egy ilyet utána
            priceTextBox.Text = total.ToString() + " Ft";

        }

        private void coffeeDropdownMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            if (coffeeDropdownMenu.Text == "Presso Kávé")
            {
                total += pressoAr;
                
            }
            else if (coffeeDropdownMenu.Text == "Hosszú Kávé")
            {
                total += hosszuKaveAr;
                
            }
            else if (coffeeDropdownMenu.Text == "Ristretto")
            {
                total += ristAr;

            }
            else if (coffeeDropdownMenu.Text == "Americano")
            {
                total += americanoAr;
            }
            else
            {
                total += teaAr;
            }
            priceTextBox.Text = total.ToString() + " Ft";
        }

        private void milkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (milkCheckBox.Checked)
            {
                total += tejAr;
            }
            else
            {
                total -= tejAr;
            }
            priceTextBox.Text = total.ToString() + " Ft";
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
        private void depositBtn_Click(object sender, EventArgs e)
        {
            try
            {
                balance += int.Parse(depositTextBox.Text);
                balanceTextBox.Text = balance.ToString() + " Ft";
            }
            catch (Exception)
            {
                MessageBox.Show("Csak egész számot adhat meg!");
            }


            depositTextBox.Clear();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            //Végösszeg kiszámítás
            if (coffeeDropdownMenu.Text == "Presso Kávé")
            {
                total += pressoAr;
            }
            else if (coffeeDropdownMenu.Text == "Hosszú Kávé")
            {
                total += hosszuKaveAr;
            }
            else if (coffeeDropdownMenu.Text == "Ristretto")
            {
                total += ristAr;
            }
            else if (coffeeDropdownMenu.Text == "Americano")
            {
                total += americanoAr;
            }
            else
            {
                total += teaAr;
            }

            switch (sugarBar.Value)
            {
                case 1:
                    total += 50;
                    break;

                case 2:
                    total += 75;
                    break;

                case 3:
                    total += 100;
                    break;

                case 4:
                    total += 125;
                    break;

                default:
                    break;
            }


            priceTextBox.Text = total.ToString() + " Ft";
            MessageBox.Show("A végösszeg: " + priceTextBox.Text);
            priceTextBox.Clear();
        }
    }
}