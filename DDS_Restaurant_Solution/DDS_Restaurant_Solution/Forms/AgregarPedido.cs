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
    public partial class AgregarPedido : Form
    {
        string cnnStr = Properties.Settings.Default.cnnStr.ToString();
        static  Models.DataContext ctx = new Models.DataContext();

        public AgregarPedido()
        {
            InitializeComponent();
        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {

            //Data.DataAccess.cargarMenuP(flpMenu);
            cargarMenu();

        }
        private void cargarMenu()
        {
            var datos = (from c in ctx.Precios
                         select new
                         {
                             id = c.Menu.idMenu,
                             name = c.Menu.nombre.ToString(),
                             precio = c.precio.ToString()
                         }).ToList();


            for (int i = 0; i < datos.Count; i++)
            {
                var datoS = (from c in ctx.Precios
                             where c.idPrecio == (i + 1)
                             select new
                             {
                                 id = c.Menu.idMenu,
                                 name = c.Menu.nombre.ToString(),
                                 precio = c.precio.ToString()
                             }).FirstOrDefault();
                Button btn = new Button()
                {
                    BackColor = System.Drawing.Color.Transparent,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                    ForeColor = System.Drawing.Color.Black,
                    Size = new System.Drawing.Size(166, 54),
                    UseVisualStyleBackColor = false,
                    Tag = datoS.id,
                    Text = $"{datoS.name}\nL.{datoS.precio}"
                };
                btn.Click += btnMenu_Click;
                flpMenu.Controls.Add(btn);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //string da;
            Button botoncito = sender as Button;
            dgvPedido.Rows.Add(Data.DataAccess.devD((Convert.ToInt32(botoncito.Tag.ToString()))- 1).ToString(), Data.DataAccess.devPre((Convert.ToInt32(botoncito.Tag.ToString())) - 1).ToString(), "1", Data.DataAccess.devPre((Convert.ToInt32(botoncito.Tag.ToString())) - 1).ToString());
        }
    }
}
