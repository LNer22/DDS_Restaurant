namespace DDS_Restaurant_Solution.Forms

{
    partial class frmMesasOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesasOrdenes));
            this.panContenedor = new System.Windows.Forms.Panel();
            this.pnlApp = new System.Windows.Forms.Panel();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.BtnParallevar = new System.Windows.Forms.Button();
            this.BtnCombinar = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.panContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // panContenedor
            // 
            this.panContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.panContenedor.Controls.Add(this.dgvMesas);
            this.panContenedor.Controls.Add(this.BtnParallevar);
            this.panContenedor.Controls.Add(this.BtnCombinar);
            this.panContenedor.Controls.Add(this.BtnPagar);
            this.panContenedor.Controls.Add(this.BtnImprimir);
            this.panContenedor.Controls.Add(this.pnlApp);
            this.panContenedor.Location = new System.Drawing.Point(0, 0);
            this.panContenedor.Name = "panContenedor";
            this.panContenedor.Size = new System.Drawing.Size(750, 449);
            this.panContenedor.TabIndex = 0;
            // 
            // pnlApp
            // 
            this.pnlApp.Location = new System.Drawing.Point(637, 222);
            this.pnlApp.Name = "pnlApp";
            this.pnlApp.Size = new System.Drawing.Size(200, 100);
            this.pnlApp.TabIndex = 26;
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMesas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesas.EnableHeadersVisualStyles = false;
            this.dgvMesas.Location = new System.Drawing.Point(12, 12);
            this.dgvMesas.MultiSelect = false;
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.RowTemplate.Height = 24;
            this.dgvMesas.Size = new System.Drawing.Size(672, 425);
            this.dgvMesas.TabIndex = 25;
            this.dgvMesas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellDoubleClick);
            // 
            // BtnParallevar
            // 
            this.BtnParallevar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnParallevar.BackColor = System.Drawing.Color.White;
            this.BtnParallevar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnParallevar.BackgroundImage")));
            this.BtnParallevar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnParallevar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnParallevar.Location = new System.Drawing.Point(691, 132);
            this.BtnParallevar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnParallevar.Name = "BtnParallevar";
            this.BtnParallevar.Size = new System.Drawing.Size(50, 36);
            this.BtnParallevar.TabIndex = 23;
            this.BtnParallevar.UseVisualStyleBackColor = false;
            // 
            // BtnCombinar
            // 
            this.BtnCombinar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCombinar.BackColor = System.Drawing.Color.White;
            this.BtnCombinar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCombinar.BackgroundImage")));
            this.BtnCombinar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCombinar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCombinar.Location = new System.Drawing.Point(691, 92);
            this.BtnCombinar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCombinar.Name = "BtnCombinar";
            this.BtnCombinar.Size = new System.Drawing.Size(50, 36);
            this.BtnCombinar.TabIndex = 19;
            this.BtnCombinar.UseVisualStyleBackColor = false;
            // 
            // BtnPagar
            // 
            this.BtnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPagar.BackColor = System.Drawing.Color.White;
            this.BtnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPagar.BackgroundImage")));
            this.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPagar.Location = new System.Drawing.Point(691, 52);
            this.BtnPagar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(50, 36);
            this.BtnPagar.TabIndex = 18;
            this.BtnPagar.UseVisualStyleBackColor = false;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimir.BackColor = System.Drawing.Color.White;
            this.BtnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.BackgroundImage")));
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImprimir.Location = new System.Drawing.Point(691, 12);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(50, 36);
            this.BtnImprimir.TabIndex = 17;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click_1);
            // 
            // frmMesasOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 449);
            this.Controls.Add(this.panContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMesasOrdenes";
            this.Text = "Mesas2";
            this.Load += new System.EventHandler(this.frmMesasOrdenes_Load);
            this.panContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panContenedor;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Button BtnParallevar;
        private System.Windows.Forms.Button BtnCombinar;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Panel pnlApp;
    }
}