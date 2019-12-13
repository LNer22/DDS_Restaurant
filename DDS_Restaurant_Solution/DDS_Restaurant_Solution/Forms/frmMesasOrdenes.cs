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
    public partial class frmMesasOrdenes : Form
    {
        public static int id = 0,idp = 0;
        string cnnStr = Properties.Settings.Default.cnnStr.ToString();
        static Models.DataContext ctx = new Models.DataContext();
        public frmMesasOrdenes()
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
            if (Application.OpenForms["AgregarPedido"] == null)
            {
                panContenedor.SendToBack();
                panContenedor.Visible = false;

            }
        }
        private void frmMesasOrdenes_Load(object sender, EventArgs e)
        {
            var datos = (from c in ctx.Mesas
                         where c.activa == true
                         select new
                         {
                             c.idMesa,
                             c.numMesa,
                             c.estadoMesa
                         }).ToList();
            foreach (var item in datos)
            {
                string esMEsa = "";
                if (item.estadoMesa == true)
                {
                    esMEsa = "Disponible";
                }else
                {
                    esMEsa = "Ocupada";
                }
                Button btn = new Button()
                {
                    BackColor = System.Drawing.Color.Transparent,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                    ForeColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(180, 50),
                    UseVisualStyleBackColor = false,
                    Tag = item.idMesa,
                    Text = $"Mesa N°{item.numMesa} \n {esMEsa}"
                };
                flpMesas.Controls.Add(btn);
                btn.Click += btnMenu_Click;

            }
            Button btn1 = new Button()
            {
                BackColor = System.Drawing.Color.Transparent,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                ForeColor = System.Drawing.Color.LightBlue,
                Size = new System.Drawing.Size(180, 50),
                Tag = "0",
                UseVisualStyleBackColor = false,
                Text = $"P/ Llevar"
            };
            flpMesas.Controls.Add(btn1);
            Button btn2 = new Button()
            {
                BackColor = System.Drawing.Color.Transparent,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                ForeColor = System.Drawing.Color.LightSalmon,
                Tag = "0",
                Size = new System.Drawing.Size(180, 50),
                UseVisualStyleBackColor = false,
                Text = $"A Domiciio"
            };
            flpMesas.Controls.Add(btn2);

            btn2.Click += btnMenu_Click;
            btn1.Click += btnMenu_Click;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button botoncito = sender as Button;
            if (Convert.ToInt32(botoncito.Tag.ToString()) > 0)
            {
                id =Convert.ToInt32(botoncito.Tag.ToString());
                panContenedor.Visible = true;
                panContenedor.BringToFront();
                int lstid = ctx.Pedidos.Last().idPedido + 1;
                idp = lstid;
                Pedido pd = new Pedido
                {
                    idPedido = lstid
                };
                ctx.Pedidos.Add(pd);
                AbrirFormulario<AgregarPedido>();
            }
        }
    }
}

