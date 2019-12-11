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
    public partial class frmMesasOrdenes : Form
    {
        public frmMesasOrdenes()
        {
            InitializeComponent();
        }
        
        private void frmMesasOrdenes_Load(object sender, EventArgs e)
        {
            Button btn = new Button()
            {
                BackColor = System.Drawing.Color.Transparent,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                ForeColor = System.Drawing.Color.Black,
                Size = new System.Drawing.Size(180, 50),
                UseVisualStyleBackColor = false,
                Tag = "",
                Text = $""
            };
            //btn.Click += btnMenu_Click;
        }
    }
}
