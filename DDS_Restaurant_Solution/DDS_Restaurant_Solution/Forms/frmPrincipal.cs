using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DDS_Restaurant_Solution.Forms;


namespace DDS_Restaurant_Solution.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        #region "Funcionalidades"
        #region "Barra de comandos"
        private void setMaxRestore()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaxRestore_Click_1(object sender, EventArgs e)
        {
            setMaxRestore();
        }
        
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region "Abrir formulario hijo"
        private void AbrirFormularioHijo(object frmHijo)
        {
            if (panContenedors.Controls.Count > 0)
                panContenedors.Controls.RemoveAt(0);

            Form frm = frmHijo as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            panContenedors.Controls.Add(frm);
            panContenedors.Tag = frm;
            frm.Show();
            panVertical.Width = 42;

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panContenedors.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panContenedors.Controls.Add(formulario);
                panContenedors.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                panVertical.Width = 47;
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        #endregion
        #region "Mouse Move"
        private void panVertical_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 47)
            {
                panVertical.Width = 182;
            }
        }

        private void panContenedors_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 182)
            {
                panVertical.Width = 47;
            }
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 182)
            {
                panVertical.Width = 47;
            }
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 47)
            {
                panVertical.Width = 182;
            }
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 47)
            {
                panVertical.Width = 182;
            }
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 47)
            {
                panVertical.Width = 182;
            }
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 47)
            {
                panVertical.Width = 182;
            }
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 47)
            {
                panVertical.Width = 182;
            }
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            if (panVertical.Width == 47)
            {
                panVertical.Width = 182;
            }
        }
        #endregion
        #region "Links"
        private void button5_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new frmMesasOrdenes());
            AbrirFormulario<frmMesasOrdenes>();

        }

        #region "btnLimpiar"
        private void button6_Click(object sender, EventArgs e)
        {
            while (panContenedors.Controls.Count > 0)
            {
                int i = 0;
                panContenedors.Controls.RemoveAt(i);
                i++;

            }
            //if (panContenedors.Controls.Count > 0)
            //{
            //    for (int i = 0; i < panContenedors.Controls.Count; i++)
            //    {
            //        panContenedors.Controls.RemoveAt(i);
            //    }
            //} 
        }
        #endregion

        private void button9_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new frmMesas());
            AbrirFormulario<frmMesas>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDetalle>();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario<frmMesasOrdenes>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCliente>();
        }

        #endregion

        #endregion
        //private void btnSlideMenu_Click(object sender, EventArgs e)
        //{
        //    if (panVertical.Width == 42)
        //    {
        //        panVertical.Width = 182;
        //        //btnSlideMenu.Image = DDS_Restaurant_Solution.Properties.Resources.flecha_hacia_la_izquierda;
        //        //btnSlideMenu.Location = new Point(1, 0);
        //    }
        //    else
        //    {
        //        panVertical.Width = 42;
        //        //btnSlideMenu.Image = DDS_Restaurant_Solution.Properties.Resources.flecha_derecha;
        //        //btnSlideMenu.Location = new Point(159, 0);
        //    }
        //}

    }
}
