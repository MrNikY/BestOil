namespace BestOil
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Form1 bestOil = new Form1(textBox1.Text == "admin" ? true : false, comboBox1.Text);
                bestOil.ShowDialog();
            }
        }
    }
}
