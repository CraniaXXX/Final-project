namespace PasswordManager
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Christian" && textBox2.Text == "123")
            {
                MessageBox.Show("Welcome to PasswordManager!");
                Dashboard n = new Dashboard();
                n.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You put invalid Account");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration n = new registration();
            n.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}