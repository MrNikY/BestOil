using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using Timer = System.Windows.Forms.Timer;

namespace BestOil
{
    public partial class Form1 : Form
    {
        BindingList<string> namesPetrol = new BindingList<string>(File.ReadAllLines("files\\namesPetrol.txt").ToList());
        BindingList<string> pricesPetrol = new BindingList<string>(File.ReadAllLines("files\\pricesPetrol.txt").ToList());
        BindingList<string> namesProduct = new BindingList<string>(File.ReadAllLines("files\\namesProduct.txt").ToList());
        BindingList<string> pricesProduct = new BindingList<string>(File.ReadAllLines("files\\pricesProduct.txt").ToList());
        List<Product> products = new();

        Timer timer = new();

        bool cafePriceReadOnly = true;

        bool Admin = false;


        public Form1(bool admin)
        {
            Admin = admin;

            InitializeComponent();
            this.Text = "BestOil";

            pictureBox1.ImageLocation = "files\\UAH.png";

            typeOfPetrol.DataSource = namesPetrol.ToArray();

            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Enabled = false;

            if (Admin)
            {
                this.Height = 350;
                groupBox1.Size = new Size(228, 272);
                miniCafe.Size = new Size(317, 272);

                ForPayment1.Visible = false;
                ForPayment2.Visible = false;
                LitersMoney.Visible = false;
                litersTextBox.Visible = false;
                moneyTextBox.Visible = false;
                label4.Visible = false;
                label1.Visible = false;

                GasButtons.Visible = true;
                CafeButtons.Visible = true;
                price.ReadOnly = false;
                cafePriceReadOnly = false;

                this.FormClosed += Form1_FormClosed;
            }

            CreateProducts();
        }

        private void CreateProducts()
        {
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
                    CheckBox = checkBox,
                    TextBox_Price = textBoxPrice,
                    Amount = numericUpDownAmount
                });

                panelMiniCafe.Controls.Add(checkBox);
                panelMiniCafe.Controls.Add(textBoxPrice);
                panelMiniCafe.Controls.Add(numericUpDownAmount);
            }
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
                    product.CheckBox.Checked = false;
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
                if (product.CheckBox == check)
                {
                    if (Admin)
                    {
                        product.TextBox_Price.ReadOnly = false;
                    }
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
                if (products[i].CheckBox.Checked == true)
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
                ForPayment1.Text = "For payment";
                PaymentType.Text = "UAH";
            }
            else
            {
                litersTextBox.Enabled = false;
                moneyTextBox.Enabled = true;
                ForPayment1.Text = "For fueling";
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Save changes?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllLines("files\\namesPetrol.txt", namesPetrol);
                File.WriteAllLines("files\\pricesPetrol.txt", pricesPetrol);
                File.WriteAllLines("files\\namesProduct.txt", namesProduct);
                File.WriteAllLines("files\\pricesProduct.txt", pricesProduct);
            }
        }

        private void deleteGas_Click(object sender, EventArgs e)
        {
            int index = typeOfPetrol.SelectedIndex;
            if (MessageBox.Show($"Delete {namesPetrol[index]}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                namesPetrol.RemoveAt(index);
                pricesPetrol.RemoveAt(index);
                typeOfPetrol.DataSource = namesPetrol;
                typeOfPetrol.SelectedIndex = 0;
                price.Text = pricesPetrol[namesPetrol.IndexOf(typeOfPetrol.Text)].ToString();
            }
        }

        private void editGas_Click(object sender, EventArgs e)
        {
            int index = typeOfPetrol.SelectedIndex;
            try
            {
                double newPrice = Math.Round(double.Parse(price.Text), 2);

                if (newPrice > 0)
                {
                    if (MessageBox.Show($"Assign {newPrice} to {namesPetrol[index]}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pricesPetrol[index] = (newPrice).ToString();
                    }
                }
                else
                    throw new Exception();
            }
            catch { MessageBox.Show("Wrong price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            price.Text = pricesPetrol[namesPetrol.IndexOf(typeOfPetrol.Text)].ToString();
        }

        private void addGas_Click(object sender, EventArgs e)
        {
            AddForm addForm = new();
            addForm.Text = "Add Fuel";
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                namesPetrol.Add(addForm.Product);
                pricesPetrol.Add(addForm.Price);
                typeOfPetrol.DataSource = namesPetrol;
                typeOfPetrol.SelectedIndex = 0;
            }
        }

        private void addCafe_Click(object sender, EventArgs e)
        {
            AddForm addForm = new();
            addForm.Text = "Add Product";
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                namesProduct.Add(addForm.Product);
                pricesProduct.Add(addForm.Price);
                panelMiniCafe.Controls.Clear();
                products.Clear();
                CreateProducts();
            }
        }

        private void deleteCafe_Click(object sender, EventArgs e)
        {
            List<int> productsIndexToDelete = new();
            string tempStr = "";
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].CheckBox.Checked)
                {
                    productsIndexToDelete.Add(i);
                    tempStr += $"{products[i].Name}, ";
                }
            }
            tempStr = tempStr.Remove(tempStr.Length - 2);

            if (MessageBox.Show($"Delete {tempStr}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productsIndexToDelete.Reverse();
                foreach (int i in productsIndexToDelete)
                {
                    namesProduct.RemoveAt(i);
                    pricesProduct.RemoveAt(i);
                }
            }
            panelMiniCafe.Controls.Clear();
            products.Clear();
            CreateProducts();
        }

        private void editCafe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].CheckBox.Checked)
                {
                    try
                    {
                        double newPrice = Math.Round(double.Parse(products[i].TextBox_Price.Text), 2);

                        if (newPrice > 0)
                        {
                            pricesProduct[i] = (newPrice).ToString();
                        }
                        else
                            throw new Exception();
                    }
                    catch { MessageBox.Show("Wrong price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            panelMiniCafe.Controls.Clear();
            products.Clear();
            CreateProducts();
        }
    }



    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public CheckBox CheckBox { get; set; }
        public TextBox TextBox_Price { get; set; }
        public NumericUpDown Amount { get; set; }
    }
}