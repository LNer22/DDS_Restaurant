namespace DDS_Restaurant_Solution.Forms
{
    partial class frmMesas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesas));
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.panContenedor = new System.Windows.Forms.Panel();
            this.BtnEliminarMesa = new System.Windows.Forms.Button();
            this.BtnLiberar = new System.Windows.Forms.Button();
            this.BtnAñadirMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 14F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMesas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMesas.EnableHeadersVisualStyles = false;
            this.dgvMesas.Location = new System.Drawing.Point(12, 2);
            this.dgvMesas.MultiSelect = false;
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.RowTemplate.Height = 24;
            this.dgvMesas.Size = new System.Drawing.Size(598, 383);
            this.dgvMesas.TabIndex = 15;
            // 
            // panContenedor
            // 
            this.panContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContenedor.Location = new System.Drawing.Point(0, 0);
            this.panContenedor.Name = "panContenedor";
            this.panContenedor.Size = new System.Drawing.Size(676, 397);
            this.panContenedor.TabIndex = 16;
            this.panContenedor.Visible = false;
            // 
            // BtnEliminarMesa
            // 
            this.BtnEliminarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarMesa.BackColor = System.Drawing.Color.White;
            this.BtnEliminarMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarMesa.BackgroundImage")));
            this.BtnEliminarMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarMesa.Location = new System.Drawing.Point(617, 42);
            this.BtnEliminarMesa.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarMesa.Name = "BtnEliminarMesa";
            this.BtnEliminarMesa.Size = new System.Drawing.Size(50, 36);
            this.BtnEliminarMesa.TabIndex = 8;
            this.BtnEliminarMesa.UseVisualStyleBackColor = false;
            // 
            // BtnLiberar
            // 
            this.BtnLiberar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLiberar.BackColor = System.Drawing.Color.White;
            this.BtnLiberar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLiberar.BackgroundImage")));
            this.BtnLiberar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLiberar.Location = new System.Drawing.Point(617, 82);
            this.BtnLiberar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLiberar.Name = "BtnLiberar";
            this.BtnLiberar.Size = new System.Drawing.Size(50, 36);
            this.BtnLiberar.TabIndex = 9;
            this.BtnLiberar.UseVisualStyleBackColor = false;
            // 
            // BtnAñadirMesa
            // 
            this.BtnAñadirMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAñadirMesa.BackColor = System.Drawing.Color.White;
            this.BtnAñadirMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAñadirMesa.BackgroundImage")));
            this.BtnAñadirMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadirMesa.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAñadirMesa.Location = new System.Drawing.Point(617, 2);
            this.BtnAñadirMesa.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAñadirMesa.Name = "BtnAñadirMesa";
            this.BtnAñadirMesa.Size = new System.Drawing.Size(50, 36);
            this.BtnAñadirMesa.TabIndex = 7;
            this.BtnAñadirMesa.UseVisualStyleBackColor = false;
            this.BtnAñadirMesa.Click += new System.EventHandler(this.BtnAñadirMesa_Click);
            // 
            // frmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 397);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.BtnLiberar);
            this.Controls.Add(this.BtnEliminarMesa);
            this.Controls.Add(this.BtnAñadirMesa);
            this.Controls.Add(this.panContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.frmMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Panel panContenedor;
        private System.Windows.Forms.Button BtnEliminarMesa;
        private System.Windows.Forms.Button BtnLiberar;
        private System.Windows.Forms.Button BtnAñadirMesa;
    }
}