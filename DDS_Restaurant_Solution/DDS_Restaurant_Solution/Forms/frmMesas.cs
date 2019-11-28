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
        public static bool estado = false;
        public static string sucursal;
        public static int capacidad;
        public static int num;

        public frmMesas()
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

        private void frmMesas_Load(object sender, EventArgs e)
        {
            Data.DataAccess.cargarMesas(dgvMesas);
        }
        private void CloseForms(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms["frmAñadirMesa"] == null)
            {
                panContenedor.SendToBack();
                panContenedor.Visible = false;
                Data.DataAccess.cargarMesas(dgvMesas);

            }
        }
        private void BtnAñadirMesa_Click_1(object sender, EventArgs e)
        {
            panContenedor.Visible = true;
            panContenedor.BringToFront();
            //AbrirFormulario(new frmAñadirMesa());
            frmAñadirMesa.id = 0;
            AbrirFormulario<frmAñadirMesa>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panContenedor.Visible = true;
            panContenedor.BringToFront();
            //AbrirFormulario(new frmAñadirMesa());
            frmAñadirMesa.id = Convert.ToInt32(dgvMesas.CurrentRow.Cells[0].Value);
            capacidad = Convert.ToInt32(dgvMesas.CurrentRow.Cells[2].Value);
            num = Convert.ToInt32(dgvMesas.CurrentRow.Cells[1].Value);
            AbrirFormulario<frmAñadirMesa>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are u sure?", "Elminar Mesa", MessageBoxButtons.YesNo);
            if (dialogResult.ToString() == DialogResult.Yes.ToString())
            {
                Data.DataAccess.deleteM(Data.DataAccess.devM(Convert.ToInt32(dgvMesas.CurrentRow.Cells[0].Value)));
                Data.DataAccess.cargarMesas(dgvMesas);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
