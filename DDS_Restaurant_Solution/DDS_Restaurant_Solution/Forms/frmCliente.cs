using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDS_Restaurant_Solution.Forms;

namespace DDS_Restaurant_Solution
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panContenedor.Controls.Add(formulario);
                panContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmAñadirCliente"] == null)
            {
                panContenedor.SendToBack();
                panContenedor.Visible = false;
                Data.DataAccess.cargarClientes(dgvMesas);

            }
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            Data.DataAccess.cargarClientes(dgvMesas);
        }

        private void BtnAñadirMesa_Click(object sender, EventArgs e)
        {
            panContenedor.Visible = true;
            panContenedor.BringToFront();
            frmAñadirCliente.id = "0";
            AbrirFormulario<frmAñadirCliente>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panContenedor.Visible = true;
            panContenedor.BringToFront();
            frmAñadirCliente.id = dgvMesas.CurrentRow.Cells[0].Value.ToString();
            AbrirFormulario<frmAñadirCliente>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are u sure?", "Elminar Mesa", MessageBoxButtons.YesNo);
            if (dialogResult.ToString() == DialogResult.Yes.ToString())
            {
                Data.DataAccess.eliminarCliente(dgvMesas.CurrentRow.Cells[0].Value.ToString(), false);
                Data.DataAccess.cargarClientes(dgvMesas);
            }
        }
    }
}
