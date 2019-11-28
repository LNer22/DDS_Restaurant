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
    public partial class frmMesasOrdenes : Form
    {
        public frmMesasOrdenes()
        {
            InitializeComponent();
        }
        private void AbrirFormularioHijo(object frmHijo)
        {
            if (pnlApp.Controls.Count > 0)
                pnlApp.Controls.RemoveAt(0);
            pnlApp.BringToFront();
            pnlApp.Dock = DockStyle.Fill;

            Form frm = frmHijo as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlApp.Controls.Add(frm);
            pnlApp.Tag = frm;
            frm.Show();

        }
        private void frmMesasOrdenes_Load(object sender, EventArgs e)
        {
            Data.DataAccess.cargarMesas(dgvMesas);
        }
        
        private void dgvMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvMesas.CurrentRow.Cells[0].Value);
            AbrirFormularioHijo(new Forms.AgregarPedido());
            MessageBox.Show($"ID:{id}");
        }

        private void BtnImprimir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
