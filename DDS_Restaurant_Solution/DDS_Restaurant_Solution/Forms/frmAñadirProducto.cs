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
    public partial class frmAñadirProducto : Form
    {

        public static int id = 0;
        public frmAñadirProducto()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void selectItemVyValue(ComboBox cbo, string val)
        {
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                var prop = cbo.Items[i].GetType().GetProperty(cbo.ValueMember);
                if (prop != null && prop.GetValue(cbo.Items[i], null).ToString() == val)
                {
                    cbo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void frmAñadirProducto_Load(object sender, EventArgs e)
        {
            Data.DataAccess.cargarTipo(comboBox1);
            if (id != 0)
            {

                button1.Text = "Guardar";
                //comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                //comboBox1.SelectedValue = Data.DataAccess.devTipo(frmDetalle.tipoP) - 1;
                comboBox1.SelectedIndex = comboBox1.FindStringExact(frmDetalle.tipoP);
                //comboBox1.SelectedIndex = comboBox1.Items.IndexOf(frmDetalle.tipoP);
                //comboBox1.SelectedItem = frmDetalle.tipoP;
                //comboBox1.Text = frmDetalle.tipoP;
                //selectItemVyValue(comboBox1, frmDetalle.tipoP);
                textBox1.Text = frmDetalle.desc;
                numericUpDown1.Value = frmDetalle.pre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Data.DataAccess.updateP(id, Convert.ToInt32(comboBox1.SelectedValue), textBox1.Text, numericUpDown1.Value);
                this.Close();
            }
            else
            {
                Models.Producto m = new Models.Producto()
                {
                    descripcion = textBox1.Text,
                    idTipoProducto = Convert.ToInt32(comboBox1.SelectedValue),
                    estado = true,
                    precio = numericUpDown1.Value
                };

                Data.DataAccess.añadirP(m);
                Close();
            }
        }
    }
}
