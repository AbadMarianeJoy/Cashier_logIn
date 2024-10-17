using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Laboratory
{
    public partial class Form1 : Form
    {

        public static Form2 instance;
        public Form1()
        {
            InitializeComponent();
            textBox_Password.PasswordChar = '*';
        }
       public string correctUsername = "Cashier101";
       public string correctPassword = "Sornahuhu";

      
            private void button1_Click(object sender, EventArgs e)
            {
                string user = textBox_UserName.Text;
                string pass = textBox_Password.Text;

                if (user == correctUsername && pass == correctPassword)

                {
                MessageBox.Show("Welcome Yanyan Abad at CS Department");
                Form2 form = new Form2();

                
                    form.Show(); 
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("You entered invalid credentials");
                }
            }
        }
    }

