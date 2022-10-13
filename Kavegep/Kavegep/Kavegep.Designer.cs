namespace Kavegep
{
    partial class Kavegep
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.coffeeDropdownMenu = new System.Windows.Forms.ComboBox();
            this.milkCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.sugarBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kávéautomata";
            // 
            // coffeeDropdownMenu
            // 
            this.coffeeDropdownMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coffeeDropdownMenu.FormattingEnabled = true;
            this.coffeeDropdownMenu.Items.AddRange(new object[] {
            "Presso Kávé",
            "Hosszú Kávé",
            "Ristretto",
            "Americano",
            "Tea"});
            this.coffeeDropdownMenu.Location = new System.Drawing.Point(56, 70);
            this.coffeeDropdownMenu.Name = "coffeeDropdownMenu";
            this.coffeeDropdownMenu.Size = new System.Drawing.Size(219, 28);
            this.coffeeDropdownMenu.TabIndex = 1;
            // 
            // milkCheckBox
            // 
            this.milkCheckBox.AutoSize = true;
            this.milkCheckBox.Location = new System.Drawing.Point(56, 104);
            this.milkCheckBox.Name = "milkCheckBox";
            this.milkCheckBox.Size = new System.Drawing.Size(50, 24);
            this.milkCheckBox.TabIndex = 2;
            this.milkCheckBox.Text = "Tej";
            this.milkCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.milkCheckBox.UseVisualStyleBackColor = true;
            this.milkCheckBox.CheckedChanged += new System.EventHandler(this.milkCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cukor: ";
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(56, 212);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(105, 29);
            this.minusBtn.TabIndex = 4;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(167, 212);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(107, 29);
            this.plusBtn.TabIndex = 5;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // sugarBar
            // 
            this.sugarBar.Location = new System.Drawing.Point(56, 177);
            this.sugarBar.Name = "sugarBar";
            this.sugarBar.Size = new System.Drawing.Size(219, 29);
            this.sugarBar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ár: ";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(86, 267);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(189, 27);
            this.priceTextBox.TabIndex = 8;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(181, 300);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(94, 29);
            this.payBtn.TabIndex = 9;
            this.payBtn.Text = "Fizetés";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bankkártya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Egyenleg: ";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(424, 70);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(191, 27);
            this.balanceTextBox.TabIndex = 12;
            this.balanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Feltöltés: ";
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(354, 148);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(261, 27);
            this.depositTextBox.TabIndex = 14;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(521, 184);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(94, 29);
            this.depositBtn.TabIndex = 15;
            this.depositBtn.Text = "Feltöltés";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // Kavegep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 387);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sugarBar);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.milkCheckBox);
            this.Controls.Add(this.coffeeDropdownMenu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Kavegep";
            this.Text = "Kávégép";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox coffeeDropdownMenu;
        private CheckBox milkCheckBox;
        private Label label2;
        private Button minusBtn;
        private Button plusBtn;
        private ProgressBar sugarBar;
        private Label label3;
        private TextBox priceTextBox;
        private Button payBtn;
        private Label label4;
        private Label label5;
        private TextBox balanceTextBox;
        private Label label6;
        private TextBox depositTextBox;
        private Button depositBtn;
    }
}