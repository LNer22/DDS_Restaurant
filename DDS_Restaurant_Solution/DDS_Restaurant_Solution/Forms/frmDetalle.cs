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
    public partial class frmDetalle : Form
    {
        public static string desc, tipoP, pre;

        public frmDetalle()
        {
            InitializeComponent();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            Data.DataAccess.cargarProductos(dgvMesas);
        }

        List<string> UsedColors = new List<string>();
        private Color RandColor()
        {
            Random x = new Random();
            int r, g, b;
            Color myRgbColor = new Color();
            while (true)
            {
                r = x.Next(180, 255);
                g = x.Next(180, 255);
                b = x.Next(180, 255);
                if (!UsedColors.Contains(r + "," + g + "," + b))
                {
                    UsedColors.Add(r + "," + g + "," + b);
                    break;
                }
            }
            myRgbColor = Color.FromArgb(r, g, b);
            return myRgbColor;
        }
        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {

            if (bunifuSwitch1.Value == true)
            {
                Data.DataAccess.cargarProductos(dgvMesas);
            }
            else
            {
                string lst = "";
                Color lstColor  = Color.AliceBlue;
                Data.DataAccess.cargarMenu(dgvMesas);
                for (int i = 0; i < dgvMesas.RowCount; i++)
                {
                    if (i == 0)
                    {
                        dgvMesas.Rows[i].DefaultCellStyle.BackColor = RandColor();
                        lstColor = dgvMesas.Rows[i].DefaultCellStyle.BackColor;
                    }
                    if (dgvMesas.Rows[i].Cells[1].Value.ToString() == lst)
                    {
                        dgvMesas.Rows[i].DefaultCellStyle.BackColor = lstColor;
                        lstColor = dgvMesas.Rows[i].DefaultCellStyle.BackColor;
                    }
                    else if (dgvMesas.Rows[i].Cells[1].Value.ToString() != lst && i>0)
                    {
                        dgvMesas.Rows[i].DefaultCellStyle.BackColor = RandColor();
                        lstColor = dgvMesas.Rows[i].DefaultCellStyle.BackColor;
                    }
                    lst = dgvMesas.Rows[i].Cells[1].Value.ToString();
                }
            }
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
            if (Application.OpenForms["frmAñadirProducto"] == null )
            {
                panContenedor.SendToBack();
                panContenedor.Visible = false;
                if (bunifuSwitch1.Value == true)
                {
                    Data.DataAccess.cargarProductos(dgvMesas);
                }
                else
                {
                    string lst = "";
                    Color lstColor  = Color.AliceBlue;
                    Data.DataAccess.cargarMenu(dgvMesas);
                    for (int i = 0; i < dgvMesas.RowCount; i++)
                    {
                        if (i == 0)
                        {
                            dgvMesas.Rows[i].DefaultCellStyle.BackColor = RandColor();
                            lstColor = dgvMesas.Rows[i].DefaultCellStyle.BackColor;
                        }
                        if (dgvMesas.Rows[i].Cells[1].Value.ToString() == lst)
                        {
                            dgvMesas.Rows[i].DefaultCellStyle.BackColor = lstColor;
                            lstColor = dgvMesas.Rows[i].DefaultCellStyle.BackColor;
                        }
                        else if (dgvMesas.Rows[i].Cells[1].Value.ToString() != lst && i > 0)
                        {
                            dgvMesas.Rows[i].DefaultCellStyle.BackColor = RandColor();
                            lstColor = dgvMesas.Rows[i].DefaultCellStyle.BackColor;
                        }
                        lst = dgvMesas.Rows[i].Cells[1].Value.ToString();
                    }
                }

            }
        }

        private void BtnAñadirMesa_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value == true)
            {
                panContenedor.Visible = true;
                panContenedor.BringToFront();
                frmAñadirProducto.id = 0;
                AbrirFormulario<frmAñadirProducto>();
            }
            else
            {
                panContenedor.Visible = true;
                panContenedor.BringToFront();
                frmAñadirProducto.id = 0;
                AbrirFormulario<AgregarCombo>();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are u sure?", "Desactivar Producto", MessageBoxButtons.YesNo);
            if (dialogResult.ToString() == DialogResult.Yes.ToString())
            {
                Data.DataAccess.deleteP(Convert.ToInt32(dgvMesas.CurrentRow.Cells[0].Value), false);
                Data.DataAccess.cargarProductos(dgvMesas);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value == true)
            {
                tipoP = Convert.ToString(dgvMesas.CurrentRow.Cells[2].Value);
                desc = Convert.ToString(dgvMesas.CurrentRow.Cells[1].Value);
                pre = Convert.ToString(dgvMesas.CurrentRow.Cells[3].Value);
                panContenedor.Visible = true;
                panContenedor.BringToFront();
                frmAñadirProducto.id = Convert.ToInt32(dgvMesas.CurrentRow.Cells[0].Value);
                AbrirFormulario<frmAñadirProducto>();
            }
            else
            {

            }
        }
    }
}
