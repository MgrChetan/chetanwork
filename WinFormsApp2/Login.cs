namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String user, pass;
            user = txtUser.Text;
            pass = txtPass.Text;
            if (user == "sta001" && pass == "givemethekeys123")
            {
                MessageBox.Show("Sucessfull");
                this.Hide();
                new Booking().Show();
            }
            else
            {
                MessageBox.Show("Error");
                new Login().Show();
            }
        }
    }
}

