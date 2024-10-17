using System;
using System.Windows.Forms;

namespace Windows_Laboratory
{
    public partial class LoginForm : Form
    {
        string user;
        string pass;
        public LoginForm(string user, string pass)
        {
            user = textBox_User.Text;
            pass = textBox_Password.Text;
            InitializeComponent();
        }
    
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBox_User.Text;
            string password = textBox_Password.Text;

            if (user == "Yanyan" && password == "Dec1994")
            {
                this.DialogResult = DialogResult.OK; // Indicate successful login
                this.Close(); // Close the LoginForm
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

       
    }
}
