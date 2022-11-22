namespace BestOil
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                (Math.Round(double.Parse(textBox2.Text), 2)).ToString();
                DialogResult = DialogResult.OK;
            }
            catch { MessageBox.Show("Wrong price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public string Product
        {
            get { return textBox1.Text; }
        }

        public string Price
        {
            get { return (Math.Round(double.Parse(textBox2.Text), 2)).ToString(); }
        }
    }
}
