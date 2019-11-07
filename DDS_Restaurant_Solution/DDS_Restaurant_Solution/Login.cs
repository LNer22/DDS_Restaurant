using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS_Restaurant_Solution
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                string login = Data.DataAccess.login(textBox1.Text, Data.GeneralClass.SHA1(textBox2.Text));
                if (login == "OK")
                {
                    DialogResult = DialogResult.OK;
                }
                else if (login == "Disabled")
                {
                    MessageBox.Show("User disabled");
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña invalidos");
                }
            }
        }
        

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            
        }
        
        

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
        

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
                textBox2.ForeColor = Color.Black;
            }
        }


        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
    }
}
