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
    public partial class frmAñadirMesa : Form
    {
        public static int id = 0;
        public frmAñadirMesa()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
            frmMesas.estado = true;
            Close();
        }

        private void frmAñadirMesa_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                comboBox1.Enabled = false;
                button1.Text = "Guardar";
                //Data.DataAccess.devM(id);
                numericUpDown1.Value = frmMesas.capacidad;
                numNum.Value = frmMesas.num;
            }
            Data.DataAccess.cargarSucursal(comboBox1);
        }

        private void frmAñadirMesa_Activated(object sender, EventArgs e)
        {
            Data.DataAccess.cargarSucursal(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Data.DataAccess.updateM(id, numNum.Value.ToString(), numericUpDown1.Value.ToString());
                this.Close();
            }
            else
            {
                //MessageBox.Show($"{comboBox1.SelectedValue}");
                Models.Mesa m = new Models.Mesa()
                {
                    numMesa = Convert.ToString(numNum.Value),
                    capacidad = Convert.ToString(numericUpDown1.Value),
                    idSucursal = Convert.ToInt32(comboBox1.SelectedValue),
                    estadoMesa = true
                };

                Data.DataAccess.añadirMesa(m);
                Close();
            }
            
        }
    }
}
