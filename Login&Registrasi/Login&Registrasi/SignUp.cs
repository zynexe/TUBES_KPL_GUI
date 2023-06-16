using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Registrasi
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

        public string[] staticEmail = { "ecospheree@gmail.com", "trontoton@gmail.com", "lilipung@gmail.com" };

        public string[] staticPassword = { "eco16", "tronton31", "lili20" };

        private void SignInButton_Click_Click(object sender, EventArgs e)
        {
            string Email = textBoxEmail.Text;
            string Password = textBoxPassword.Text;
            
            Login login1 = new Login();

            bool isValidUser = CheckValidUser(Email,Password);

            if (isValidUser)
            {
                MessageBox.Show("Sign Up successful!");
                Login login = new Login(Email,Password);
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email");
            }
        }

        private bool CheckValidUser(string Email, string Password)
        {
            for (int i = 0; i < staticEmail.Length; i++)
            {
                if (Email == staticEmail[i] && Password == staticPassword[i])
                {
                    return true;
                }
            }
            return false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
