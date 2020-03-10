using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDS_Restaurant_Solution.Models;

namespace DDS_Restaurant_Solution.Forms
{
    public partial class frmAñadirCliente : Form
    {
        static string cnnStr = Properties.Settings.Default.cnnStr.ToString();
        static DataContext ctx = new DataContext();
        public static string id;
        public frmAñadirCliente()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (id == "0")
            {
                int genero;
                if (radioButton1.Checked == true)
                {
                    genero = 1;
                }
                else
                {
                    genero = 2;
                }
                Cliente cliente = new Cliente
                {
                    numIdentidad = txtIdentidad.Text,
                    nombre = txtNombre.Text,
                    apellidos = txtApellidos.Text,
                    celular = txtTelefono.Text,
                    correoElectronico = txtEmail.Text,
                    direccion = txtDireccion.Text,
                    fechaNacimiento = dtmFecha.Value,
                    idGenero = genero,
                    acctivo = true
                };
                Data.DataAccess.añadirCliente(cliente);
                Close();
            }
            else
            {
                var datos = (from c in ctx.Clientes
                             where c.numIdentidad == id.ToString()
                             orderby c.nombre descending
                             select c).SingleOrDefault();
                datos.correoElectronico = txtEmail.Text;
                datos.direccion = txtDireccion.Text;
                datos.celular = txtTelefono.Text;
                ctx.SaveChanges();
                Close();
            }
        }

        private void frmAñadirCliente_Load(object sender, EventArgs e)
        {
            var datos = (from c in ctx.Clientes
                         where c.numIdentidad == id.ToString()
                         orderby c.nombre descending
                         select c).SingleOrDefault();
            if (id != "0")
            {
                txtNombre.Text = datos.nombre;
                txtApellidos.Text = datos.apellidos;
                txtIdentidad.Text = datos.numIdentidad;
                txtTelefono.Text = datos.celular;
                txtEmail.Text = datos.correoElectronico;
                txtDireccion.Text = datos.direccion;
                dtmFecha.Value = datos.fechaNacimiento;
                if (datos.idGenero == 1)
                {
                    radioButton1.Checked = true;
                }else
                {
                    radioButton2.Checked = true;
                }
                btnAñadir.Text = "Actualizar";
                txtIdentidad.Enabled = false;
                txtNombre.Enabled = false;
                txtApellidos.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                dtmFecha.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
