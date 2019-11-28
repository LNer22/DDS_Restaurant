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
        private void log()
        {
            if (textBox1.Text != "Usuario")
            {

                if (textBox2.Text != "Contraseña")
                {
                    string login = Data.DataAccess.login(textBox1.Text, textBox2.Text);
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
                else
                {
                    errorProvider1.SetError(textBox2, "Ingrese su contraseña");
                }
            }
            else
            {
                if (textBox1.Text == "Usuario")
                {
                    errorProvider1.SetError(textBox1,"Ingrese su usuario");
                }
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Text = "";
                textBox2.isPassword = true;
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.White;
                textBox2.isPassword = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            log();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.isPassword == true)
            {
                textBox2.isPassword = false;
            }
            else
            {
                textBox2.isPassword = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                log();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                log();
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                log();
            }
        }
    }
}
