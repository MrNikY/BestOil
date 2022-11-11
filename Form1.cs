using Timer = System.Windows.Forms.Timer;

namespace BestOil
{
    public partial class Form1 : Form
    {
        List<string> namesPetrol = System.IO.File.ReadAllLines("files\\namesPetrol.txt").ToList();
        List<string> pricesPetrol = System.IO.File.ReadAllLines("files\\pricesPetrol.txt").ToList();
        List<string> namesProduct = System.IO.File.ReadAllLines("files\\namesProduct.txt").ToList();
        List<string> pricesProduct = System.IO.File.ReadAllLines("files\\pricesProduct.txt").ToList();
        List<Product> products = new();

        Timer timer = new();


        public Form1()
        {
            InitializeComponent();
            this.Text = "BestOil";

            pictureBox1.ImageLocation = "files\\UAH.png";

            typeOfPetrol.DataSource = namesPetrol.ToArray();

            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Enabled = false;

            #region products
            for (int i = 0; i < namesProduct.Count; i++)
            {
                CheckBox checkBox = new();
                checkBox.Location = new Point(0, i * 26);
                checkBox.Size = new Size(130, 19);
                checkBox.Text = namesProduct[i];
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                TextBox textBoxPrice = new();
                textBoxPrice.Location = new Point(130, i * 26);
                textBoxPrice.Size = new Size(69, 23);
                textBoxPrice.Text = pricesProduct[i].ToString();
                textBoxPrice.ReadOnly = true;

                NumericUpDown numericUpDownAmount = new();
                numericUpDownAmount.Location = new Point(209, i * 26);
                numericUpDownAmount.Size = new Size(69, 23);
                numericUpDownAmount.Minimum = 0;
                numericUpDownAmount.Maximum = 100;
                numericUpDownAmount.Enabled = false;
                numericUpDownAmount.ValueChanged += NumericUpDownAmount_ValueChanged;

                products.Add(new Product
                {
                    Name = namesProduct[i],
                    Price = decimal.Parse(pricesProduct[i]),
                    CheckBox_Enable = checkBox,
                    TextBox_Price = textBoxPrice,
                    Amount = numericUpDownAmount
                });

                panelMiniCafe.Controls.Add(checkBox);
                panelMiniCafe.Controls.Add(textBoxPrice);
                panelMiniCafe.Controls.Add(numericUpDownAmount);
            }
            #endregion
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult res = MessageBox.Show("Clear the form?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                foreach (Product product in products)
                {
                    product.Amount.Value = 0;
                    product.Amount.Enabled = false;
                    product.CheckBox_Enable.Checked = false;
                }
                typeOfPetrol_SelectedIndexChanged(sender, e);
                cafeSum.Text = "00.00";
                endSum.Text = "00.00";
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            foreach (Product product in products)
            {
                if (product.CheckBox_Enable == check)
                {
                    product.Amount.Enabled = check.Checked;
                    NumericUpDownAmount_ValueChanged(sender, e);
                    break;
                }
            }
        }

        private void NumericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            decimal SumAll = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].CheckBox_Enable.Checked == true)
                {
                    SumAll += products[i].Price * products[i].Amount.Value;
                }
            }
            cafeSum.Text = System.Math.Round(SumAll, 2).ToString();
        }

        private void typeOfPetrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            price.Text = pricesPetrol[namesPetrol.IndexOf(typeOfPetrol.Text)].ToString();
            litersTextBox.Clear();
            moneyTextBox.Clear();
            mainSum.Text = "00.00";
        }

        private void liters_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                litersTextBox.Enabled = true;
                moneyTextBox.Enabled = false;
                PaymentMain.Text = "For payment";
                PaymentType.Text = "UAH";
            }
            else
            {
                litersTextBox.Enabled = false;
                moneyTextBox.Enabled = true;
                PaymentMain.Text = "For fueling";
                PaymentType.Text = "Lit.";
            }
        }

        private void mainSumCount(object sender, EventArgs e)
        {
            if (liters.Checked)
            {
                try
                {
                    mainSum.Text = System.Math.Round((
                                                    double.Parse(pricesPetrol[namesPetrol.IndexOf(typeOfPetrol.Text)]) *
                                                    double.Parse(litersTextBox.Text)
                                                    ), 2).ToString();
                }
                catch { litersTextBox.Clear(); }
            }
            else
            {
                try
                {
                    mainSum.Text = System.Math.Round((
                                                    double.Parse(moneyTextBox.Text) /
                                                    double.Parse(pricesPetrol[namesPetrol.IndexOf(typeOfPetrol.Text)])
                                                    ), 2).ToString();
                }
                catch { moneyTextBox.Clear(); }
            }
        }

        private void count_Click(object sender, EventArgs e)
        {
            if (liters.Checked)
                endSum.Text = (double.Parse(mainSum.Text) + double.Parse(cafeSum.Text)).ToString();
            else
                endSum.Text = (double.Parse(moneyTextBox.Text) + double.Parse(cafeSum.Text)).ToString();
            timer.Enabled = true;
        }
    }



    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public CheckBox CheckBox_Enable { get; set; }
        public TextBox TextBox_Price { get; set; }
        public NumericUpDown Amount { get; set; }
    }
}