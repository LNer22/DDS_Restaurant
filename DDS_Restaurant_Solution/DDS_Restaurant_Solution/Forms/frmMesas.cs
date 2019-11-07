using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS_Restaurant_Solution.Forms
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }
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

        private void frmMesas_Load(object sender, EventArgs e)
        {
            Data.DataAccess.cargarMesas(dgvMesas);
        }

        private void BtnAñadirMesa_Click(object sender, EventArgs e)
        {
            panContenedor.Visible = true;
            panContenedor.BringToFront();
            AbrirFormularioHijo(new frmAñadirCliente());
        }
    }
}
