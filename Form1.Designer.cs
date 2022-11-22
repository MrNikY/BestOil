namespace BestOil
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GasButtons = new System.Windows.Forms.GroupBox();
            this.deleteGas = new System.Windows.Forms.Button();
            this.addGas = new System.Windows.Forms.Button();
            this.editGas = new System.Windows.Forms.Button();
            this.ForPayment1 = new System.Windows.Forms.GroupBox();
            this.mainSum = new System.Windows.Forms.Label();
            this.PaymentType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.litersTextBox = new System.Windows.Forms.TextBox();
            this.LitersMoney = new System.Windows.Forms.GroupBox();
            this.Money = new System.Windows.Forms.RadioButton();
            this.liters = new System.Windows.Forms.RadioButton();
            this.currency = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.typeOfPetrol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.miniCafe = new System.Windows.Forms.GroupBox();
            this.CafeButtons = new System.Windows.Forms.GroupBox();
            this.deleteCafe = new System.Windows.Forms.Button();
            this.addCafe = new System.Windows.Forms.Button();
            this.editCafe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ForPayment2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cafeSum = new System.Windows.Forms.Label();
            this.panelMiniCafe = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Button();
            this.endSum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.GasButtons.SuspendLayout();
            this.ForPayment1.SuspendLayout();
            this.LitersMoney.SuspendLayout();
            this.miniCafe.SuspendLayout();
            this.CafeButtons.SuspendLayout();
            this.ForPayment2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GasButtons);
            this.groupBox1.Controls.Add(this.ForPayment1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.moneyTextBox);
            this.groupBox1.Controls.Add(this.litersTextBox);
            this.groupBox1.Controls.Add(this.LitersMoney);
            this.groupBox1.Controls.Add(this.currency);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.typeOfPetrol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gas station";
            // 
            // GasButtons
            // 
            this.GasButtons.Controls.Add(this.deleteGas);
            this.GasButtons.Controls.Add(this.addGas);
            this.GasButtons.Controls.Add(this.editGas);
            this.GasButtons.Location = new System.Drawing.Point(6, 218);
            this.GasButtons.Name = "GasButtons";
            this.GasButtons.Size = new System.Drawing.Size(214, 45);
            this.GasButtons.TabIndex = 5;
            this.GasButtons.TabStop = false;
            this.GasButtons.Visible = false;
            // 
            // deleteGas
            // 
            this.deleteGas.Location = new System.Drawing.Point(144, 16);
            this.deleteGas.Name = "deleteGas";
            this.deleteGas.Size = new System.Drawing.Size(63, 23);
            this.deleteGas.TabIndex = 8;
            this.deleteGas.Text = "delete";
            this.deleteGas.UseVisualStyleBackColor = true;
            this.deleteGas.Click += new System.EventHandler(this.deleteGas_Click);
            // 
            // addGas
            // 
            this.addGas.Location = new System.Drawing.Point(6, 16);
            this.addGas.Name = "addGas";
            this.addGas.Size = new System.Drawing.Size(63, 23);
            this.addGas.TabIndex = 6;
            this.addGas.Text = "add";
            this.addGas.UseVisualStyleBackColor = true;
            this.addGas.Click += new System.EventHandler(this.addGas_Click);
            // 
            // editGas
            // 
            this.editGas.Location = new System.Drawing.Point(75, 16);
            this.editGas.Name = "editGas";
            this.editGas.Size = new System.Drawing.Size(63, 23);
            this.editGas.TabIndex = 7;
            this.editGas.Text = "edit";
            this.editGas.UseVisualStyleBackColor = true;
            this.editGas.Click += new System.EventHandler(this.editGas_Click);
            // 
            // ForPayment1
            // 
            this.ForPayment1.Controls.Add(this.mainSum);
            this.ForPayment1.Controls.Add(this.PaymentType);
            this.ForPayment1.Location = new System.Drawing.Point(6, 218);
            this.ForPayment1.Name = "ForPayment1";
            this.ForPayment1.Size = new System.Drawing.Size(214, 103);
            this.ForPayment1.TabIndex = 1;
            this.ForPayment1.TabStop = false;
            this.ForPayment1.Text = "For payment";
            // 
            // mainSum
            // 
            this.mainSum.AutoSize = true;
            this.mainSum.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainSum.Location = new System.Drawing.Point(29, 37);
            this.mainSum.Name = "mainSum";
            this.mainSum.Size = new System.Drawing.Size(104, 47);
            this.mainSum.TabIndex = 0;
            this.mainSum.Text = "00.00";
            this.mainSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentType
            // 
            this.PaymentType.AutoSize = true;
            this.PaymentType.Location = new System.Drawing.Point(176, 69);
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.Size = new System.Drawing.Size(32, 15);
            this.PaymentType.TabIndex = 6;
            this.PaymentType.Text = "UAH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lit.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "UAH";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Enabled = false;
            this.moneyTextBox.Location = new System.Drawing.Point(103, 169);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(79, 23);
            this.moneyTextBox.TabIndex = 3;
            this.moneyTextBox.TextChanged += new System.EventHandler(this.mainSumCount);
            // 
            // litersTextBox
            // 
            this.litersTextBox.Location = new System.Drawing.Point(103, 134);
            this.litersTextBox.Name = "litersTextBox";
            this.litersTextBox.Size = new System.Drawing.Size(79, 23);
            this.litersTextBox.TabIndex = 2;
            this.litersTextBox.TextChanged += new System.EventHandler(this.mainSumCount);
            // 
            // LitersMoney
            // 
            this.LitersMoney.Controls.Add(this.Money);
            this.LitersMoney.Controls.Add(this.liters);
            this.LitersMoney.Location = new System.Drawing.Point(6, 121);
            this.LitersMoney.Name = "LitersMoney";
            this.LitersMoney.Size = new System.Drawing.Size(91, 80);
            this.LitersMoney.TabIndex = 1;
            this.LitersMoney.TabStop = false;
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(6, 49);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(62, 19);
            this.Money.TabIndex = 1;
            this.Money.TabStop = true;
            this.Money.Text = "Money";
            this.Money.UseVisualStyleBackColor = true;
            // 
            // liters
            // 
            this.liters.AutoSize = true;
            this.liters.Checked = true;
            this.liters.Location = new System.Drawing.Point(6, 13);
            this.liters.Name = "liters";
            this.liters.Size = new System.Drawing.Size(50, 19);
            this.liters.TabIndex = 0;
            this.liters.TabStop = true;
            this.liters.Text = "liters";
            this.liters.UseVisualStyleBackColor = true;
            this.liters.CheckedChanged += new System.EventHandler(this.liters_CheckedChanged);
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(188, 83);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(32, 15);
            this.currency.TabIndex = 1;
            this.currency.Text = "UAH";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(61, 75);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(121, 23);
            this.price.TabIndex = 1;
            // 
            // typeOfPetrol
            // 
            this.typeOfPetrol.FormattingEnabled = true;
            this.typeOfPetrol.Location = new System.Drawing.Point(61, 37);
            this.typeOfPetrol.Name = "typeOfPetrol";
            this.typeOfPetrol.Size = new System.Drawing.Size(121, 23);
            this.typeOfPetrol.TabIndex = 1;
            this.typeOfPetrol.SelectedIndexChanged += new System.EventHandler(this.typeOfPetrol_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fuel";
            // 
            // miniCafe
            // 
            this.miniCafe.Controls.Add(this.CafeButtons);
            this.miniCafe.Controls.Add(this.label7);
            this.miniCafe.Controls.Add(this.label6);
            this.miniCafe.Controls.Add(this.ForPayment2);
            this.miniCafe.Controls.Add(this.panelMiniCafe);
            this.miniCafe.Location = new System.Drawing.Point(263, 35);
            this.miniCafe.Name = "miniCafe";
            this.miniCafe.Size = new System.Drawing.Size(317, 329);
            this.miniCafe.TabIndex = 1;
            this.miniCafe.TabStop = false;
            this.miniCafe.Text = "Mini-cafe";
            // 
            // CafeButtons
            // 
            this.CafeButtons.Controls.Add(this.deleteCafe);
            this.CafeButtons.Controls.Add(this.addCafe);
            this.CafeButtons.Controls.Add(this.editCafe);
            this.CafeButtons.Location = new System.Drawing.Point(51, 218);
            this.CafeButtons.Name = "CafeButtons";
            this.CafeButtons.Size = new System.Drawing.Size(214, 45);
            this.CafeButtons.TabIndex = 9;
            this.CafeButtons.TabStop = false;
            this.CafeButtons.Visible = false;
            // 
            // deleteCafe
            // 
            this.deleteCafe.Location = new System.Drawing.Point(144, 16);
            this.deleteCafe.Name = "deleteCafe";
            this.deleteCafe.Size = new System.Drawing.Size(63, 23);
            this.deleteCafe.TabIndex = 8;
            this.deleteCafe.Text = "delete";
            this.deleteCafe.UseVisualStyleBackColor = true;
            this.deleteCafe.Click += new System.EventHandler(this.deleteCafe_Click);
            // 
            // addCafe
            // 
            this.addCafe.Location = new System.Drawing.Point(6, 16);
            this.addCafe.Name = "addCafe";
            this.addCafe.Size = new System.Drawing.Size(63, 23);
            this.addCafe.TabIndex = 6;
            this.addCafe.Text = "add";
            this.addCafe.UseVisualStyleBackColor = true;
            this.addCafe.Click += new System.EventHandler(this.addCafe_Click);
            // 
            // editCafe
            // 
            this.editCafe.Location = new System.Drawing.Point(75, 16);
            this.editCafe.Name = "editCafe";
            this.editCafe.Size = new System.Drawing.Size(63, 23);
            this.editCafe.TabIndex = 7;
            this.editCafe.Text = "edit";
            this.editCafe.UseVisualStyleBackColor = true;
            this.editCafe.Click += new System.EventHandler(this.editCafe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price";
            // 
            // ForPayment2
            // 
            this.ForPayment2.Controls.Add(this.label5);
            this.ForPayment2.Controls.Add(this.cafeSum);
            this.ForPayment2.Location = new System.Drawing.Point(6, 221);
            this.ForPayment2.Name = "ForPayment2";
            this.ForPayment2.Size = new System.Drawing.Size(305, 100);
            this.ForPayment2.TabIndex = 2;
            this.ForPayment2.TabStop = false;
            this.ForPayment2.Text = "For payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "UAH";
            // 
            // cafeSum
            // 
            this.cafeSum.AutoSize = true;
            this.cafeSum.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cafeSum.Location = new System.Drawing.Point(41, 37);
            this.cafeSum.Name = "cafeSum";
            this.cafeSum.Size = new System.Drawing.Size(104, 47);
            this.cafeSum.TabIndex = 0;
            this.cafeSum.Text = "00.00";
            this.cafeSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMiniCafe
            // 
            this.panelMiniCafe.AutoScroll = true;
            this.panelMiniCafe.Location = new System.Drawing.Point(6, 40);
            this.panelMiniCafe.Name = "panelMiniCafe";
            this.panelMiniCafe.Size = new System.Drawing.Size(305, 161);
            this.panelMiniCafe.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.count);
            this.groupBox4.Controls.Add(this.endSum);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 130);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "For payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "UAH";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(137, 22);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(145, 100);
            this.count.TabIndex = 1;
            this.count.Text = "Count";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // endSum
            // 
            this.endSum.AutoSize = true;
            this.endSum.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endSum.Location = new System.Drawing.Point(352, 57);
            this.endSum.Name = "endSum";
            this.endSum.Size = new System.Drawing.Size(104, 47);
            this.endSum.TabIndex = 7;
            this.endSum.Text = "00.00";
            this.endSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 521);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.miniCafe);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GasButtons.ResumeLayout(false);
            this.ForPayment1.ResumeLayout(false);
            this.ForPayment1.PerformLayout();
            this.LitersMoney.ResumeLayout(false);
            this.LitersMoney.PerformLayout();
            this.miniCafe.ResumeLayout(false);
            this.miniCafe.PerformLayout();
            this.CafeButtons.ResumeLayout(false);
            this.ForPayment2.ResumeLayout(false);
            this.ForPayment2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label currency;
        private TextBox price;
        private ComboBox typeOfPetrol;
        private GroupBox LitersMoney;
        private RadioButton Money;
        private RadioButton liters;
        private TextBox moneyTextBox;
        private TextBox litersTextBox;
        private Label label4;
        private Label label1;
        private GroupBox ForPayment1;
        private Label PaymentType;
        private Label mainSum;
        private GroupBox miniCafe;
        private Panel panelMiniCafe;
        private GroupBox ForPayment2;
        private Label label5;
        private Label cafeSum;
        private Label label7;
        private Label label6;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private Button count;
        private Label label8;
        private Label endSum;
        private Button deleteGas;
        private Button editGas;
        private Button addGas;
        private GroupBox GasButtons;
        private GroupBox CafeButtons;
        private Button deleteCafe;
        private Button addCafe;
        private Button editCafe;
    }
}