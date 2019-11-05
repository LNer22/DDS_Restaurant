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

        private void AbrirFormularioHijo(object frmHijo)
        {
            if (panContenedor.Controls.Count > 0)
                panContenedor.Controls.RemoveAt(0);

            Form frm = frmHijo as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            panContenedor.Controls.Add(frm);
            panContenedor.Tag = frm;
            frm.Show();

        }

        private void setMaxRestore()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaxRestore.Image = Properties.Resources.restore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaxRestore.Image = Properties.Resources.maximize;
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

        private void btnMaxRestore_Click(object sender, EventArgs e)
        {
            setMaxRestore();
        }

        private void panTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnSlideMenu_Click(object sender, EventArgs e)
        {
            if (panMenuVertical.Width == 42)
            {
                panMenuVertical.Width = 182;
                btnSlideMenu.Image = DDS_Restaurant_Solution.Properties.Resources.atras;
            }
            else
            {
                panMenuVertical.Width = 42;
                btnSlideMenu.Image = DDS_Restaurant_Solution.Properties.Resources.proximo;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new );
        }
    }
}
