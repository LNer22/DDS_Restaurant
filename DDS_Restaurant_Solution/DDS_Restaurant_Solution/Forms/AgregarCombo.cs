using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DDS_Restaurant_Solution.Forms
{
    public partial class AgregarCombo : Form
    {
        public static int id = 0;
        int idd = id;
        float PTotal = 0;
        string cnnStr = Properties.Settings.Default.cnnStr.ToString();
        static Models.DataContext ctx = new Models.DataContext();

        public AgregarCombo()
        {
            InitializeComponent();
        }

        public void calcular()
        {
            decimal dc = 0;
            foreach (ListViewItem item in lvwDetalle.Items)
            {
                dc += Convert.ToDecimal(item.SubItems[3].Text);
            }
            dc = dc - (dc * (numericUpDown1.Value/100));
            dc = Math.Round(dc, 2);
            PTotal = float.Parse(dc.ToString());
            lblPre.Text = $"L.{dc}";

        }

        public void cargarTab(TabControl tb)
        {
            //Añadir páginas
            var datos = (from c in ctx.TipoProductos
                         select new
                         {
                             c.tipoProducto
                         }).ToList();
            foreach (var item in datos)
            {
                tb.TabPages.Add(item.tipoProducto);
            }
            //Añadir items a páginas
            //Añadir panel
            int z = 0;
            foreach (TabPage item in tb.TabPages)
            {

                FlowLayoutPanel flp = new FlowLayoutPanel { Name = $"flp{z}", Dock = DockStyle.Fill };

                item.Controls.Add(flp);
                z += 1;


            }
            //Añadir cosas al panel
            for (int i = 0; i < tb.TabPages.Count; i++)
            {
                string txt = tb.TabPages[i].Text;
                var datoSs = (from c in ctx.Productos
                              where c.TipoProducto.tipoProducto == txt
                              where c.estado == true
                              select new
                              {
                                  c.idProducto,
                                  c.descripcion,
                                  c.precio
                              }).ToList();
                for (int ii = 0; ii < datoSs.Count; ii++)
                {
                    var itm = datoSs.ElementAt(ii);
                    Button btn = new Button()
                    {
                        BackColor = System.Drawing.Color.Transparent,
                        FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                        Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                        ForeColor = System.Drawing.Color.Black,
                        Size = new System.Drawing.Size(180, 50),
                        UseVisualStyleBackColor = false,
                        Tag = itm.idProducto,
                        Text = $"{itm.descripcion} \n ${ Math.Round(itm.precio,2)}"
                    };
                    tb.TabPages[i].Controls[0].Controls.Add(btn);
                    btn.Click += btnMenu_Click;
                }
            }
        }

        public void cargarEditar()
        {
            var itms = (from c in ctx.DetalleMenus
                         where c.idMenu == id
                         select new
                         {
                             c.idProducto,
                             c.Productos.descripcion,
                             c.cantidad,
                             c.Productos.precio,
                             c.Menu.descuento,
                             c.Menu.nombre
                         }).ToList();
            textBox2.Text = itms[1].nombre.ToString();
            numericUpDown1.Value = Convert.ToDecimal((itms[1].descuento / 100));
            foreach (var item in itms)
            {
                var itemss = new ListViewItem(new[] { item.idProducto.ToString(), item.descripcion.ToString(), item.cantidad.ToString(),Math.Round(item.cantidad * item.precio,2).ToString() });
                lvwDetalle.Items.Add(itemss);
            }
        }

        private void AgregarCombo_Load(object sender, EventArgs e)
        {
            cargarTab(tbProductos);
            if (id != 0)
            {
                cargarEditar();
                calcular();
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button botoncito = sender as Button;
            char[] spearator = { '$' };
            string[] pre = botoncito.Text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            var itemss = new ListViewItem(new[] { botoncito.Tag.ToString(), botoncito.Text.ToString(), "1", pre[1] });
            if (lvwDetalle.Items.Count > 0)
            {
                ListViewItem itemLV = lvwDetalle.FindItemWithText(itemss.Text);
                if (itemLV != null)
                {
                    lvwDetalle.Items[lvwDetalle.FindItemWithText(itemss.Text).Index].SubItems[2].Text = Convert.ToString(Convert.ToInt32(lvwDetalle.Items[lvwDetalle.FindItemWithText(itemss.Text).Index].SubItems[2].Text) + 1);
                    lvwDetalle.Items[lvwDetalle.FindItemWithText(itemss.Text).Index].SubItems[3].Text = Convert.ToString(Convert.ToDecimal(lvwDetalle.Items[lvwDetalle.FindItemWithText(itemss.Text).Index].SubItems[3].Text) + Convert.ToDecimal(pre[1]));
                }
                else
                {
                    lvwDetalle.Items.Add(itemss);
                }
                calcular();
            }
            else
            {
                lvwDetalle.Items.Add(itemss);
                calcular();
            }
        }

        private void lvwDetalle_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lvwDetalle.FocusedItem.Text);
            //lvwDetalle.FocusedItem.SubItems[2].Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una cantidad", "Cantidad", $"{lvwDetalle.FocusedItem.SubItems[2].Text}");
            //MessageBox.Show(nV.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void lvwDetalle_DoubleClick(object sender, EventArgs e)
        {
            //lvwDetalle.FocusedItem.Remove();
            int d = 0;
            try
            {

                d = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una cantidad", "Cantidad", $"{lvwDetalle.FocusedItem.SubItems[2].Text}"));
            }
            catch (Exception)
            {

                d = 0;
            }
            if (d >0)
            {
                lvwDetalle.FocusedItem.SubItems[2].Text = d.ToString();
                lvwDetalle.FocusedItem.SubItems[3].Text = (Math.Round(Data.DataAccess.devPrecio(Convert.ToInt32(lvwDetalle.FocusedItem.SubItems[0].Text)) * d,2)).ToString();
                calcular();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDetalle.FocusedItem.Remove();
            calcular();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idd == 0)
            {
                Models.Menu menu = new Models.Menu
                {
                    nombre = textBox2.Text,
                    fechaCreacion = DateTime.Today,
                    estado = true,
                    descuento = float.Parse((numericUpDown1.Value / 100).ToString())
                };
                int id = Data.DataAccess.añadirCombo(menu);
                foreach (ListViewItem item in lvwDetalle.Items)
                {
                    Models.DetalleMenu detalle = new Models.DetalleMenu
                    { 
                        cantidad = Convert.ToInt32(item.SubItems[2].Text),
                        idMenu = id,
                        idProducto = Convert.ToInt32(item.SubItems[0].Text)
                    };
                    Data.DataAccess.añadirDetalle(detalle);
                }
                Models.Precios precios = new Models.Precios
                {
                    idMenu = id,
                    activo = true,
                    precio = PTotal
                };
                Data.DataAccess.añadirPrecio(precios);

                Close();
            }
            else
            {
                
                var datos = (from c in ctx.Menus
                                where c.idMenu == id
                                select c).SingleOrDefault();
                datos.nombre = textBox2.Text;
                datos.descuento = float.Parse((numericUpDown1.Value).ToString());
                foreach (ListViewItem item in lvwDetalle.Items)
                {
                    int iddd = Convert.ToInt32(item.SubItems[0].Text);
                    var datosss = (from c in ctx.DetalleMenus
                                   where c.idProducto == iddd && c.idMenu == id
                                   select c).SingleOrDefault();
                    datosss.cantidad = Convert.ToInt32(item.SubItems[2].Text);
                    //Models.DetalleMenu detalle = new Models.DetalleMenu
                    //{
                    //    cantidad = Convert.ToInt32(item.SubItems[2].Text),
                    //    idMenu = id,
                    //    idProducto = Convert.ToInt32(item.SubItems[0].Text)
                    //};
                    //Data.DataAccess.añadirDetalle(detalle);

                }
                //Models.Precios precios = new Models.Precios
                //{
                //    idMenu = id,
                //    activo = true,
                //    precio = PTotal
                //};
                //Data.DataAccess.añadirPrecio(precios);
                var datoss = (from c in ctx.Precios
                               where c.idMenu == id
                               select c).SingleOrDefault();
                datoss.precio = PTotal;
                ctx.SaveChanges();
                id = 0;
                Close();

            }
        }
    }
}
