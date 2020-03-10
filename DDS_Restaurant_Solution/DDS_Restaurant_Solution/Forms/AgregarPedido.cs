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
        float PTotal = 0,subt,tot,isv;
        string cnnStr = Properties.Settings.Default.cnnStr.ToString();
        static  Models.DataContext ctx = new Models.DataContext();

        public AgregarPedido()
        {
            InitializeComponent();
        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {
            cargarTab(tbProductos);
            //Data.DataAccess.cargarMenuP(flpMenu);
        }
        public void calcular()
        {
            decimal dc = 0;
            foreach (ListViewItem item in lvwDetalle.Items)
            {
                dc += Convert.ToDecimal(item.SubItems[3].Text);
            }
            dc = Math.Round(dc, 2);
            PTotal = float.Parse(dc.ToString());
            isv = float.Parse(Math.Round(PTotal * 0.15,2).ToString());
            tot = float.Parse(Math.Round(PTotal + isv,2).ToString());
            lblsubt.Text = $"L.{PTotal.ToString()}";
            lblisv.Text = $"L.{isv.ToString()}";
            lblTot.Text = $"L.{tot.ToString()}";

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
                    Button btn1 = new Button()
                    {
                        BackColor = System.Drawing.Color.Transparent,
                        FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                        Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                        ForeColor = System.Drawing.Color.Black,
                        Size = new System.Drawing.Size(180, 50),
                        UseVisualStyleBackColor = false,
                        Tag = itm.idProducto,
                        Text = $"{itm.descripcion} \n ${ Math.Round(itm.precio, 2)}"
                    };
                    tb.TabPages[i].Controls[0].Controls.Add(btn1);
                    btn1.Click += btnMenu_Click;
                }
            }
            //Añadir menu
            FlowLayoutPanel flp1 = new FlowLayoutPanel { Name = $"flpM", Dock = DockStyle.Fill };
            tb.TabPages.Add("Combos");
            tb.TabPages[tb.TabPages.Count - 1].Controls.Add(flp1);

            var datoX = (from c in ctx.Precios
                          where c.Menu.estado == true
                          select new
                          {
                              c.idMenu,
                              c.Menu.nombre,
                              c.precio
                          }).ToList();
            foreach (var item in datoX)
            {
                Button btn = new Button()
                {
                    BackColor = System.Drawing.Color.Transparent,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                    ForeColor = System.Drawing.Color.Black,
                    Size = new System.Drawing.Size(180, 50),
                    UseVisualStyleBackColor = false,
                    Tag = item.idMenu,
                    Text = $"{item.nombre} \n ${item.precio}"
                };
                btn.Click += btnMenu1_Click;
                int lstp = tb.TabPages.Count - 1;
                int lstflp = tb.TabPages[lstp].Controls.Count - 1;
                tb.TabPages[lstp].Controls[lstflp].Controls.Add(btn);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button botoncito = sender as Button;
            char[] spearator = { '$' };
            string[] pre = botoncito.Text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            var itemss = new ListViewItem(new[] { botoncito.Tag.ToString(), pre[0], "1", pre[1] });
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
        private void btnMenu1_Click(object sender, EventArgs e)
        {
            Button botoncito = sender as Button;
            char[] spearator = {'$'};
            string[] pre = botoncito.Text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            var itemss = new ListViewItem(new[] { botoncito.Tag.ToString(), pre[0], "1", pre[1] });
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

    }
}
