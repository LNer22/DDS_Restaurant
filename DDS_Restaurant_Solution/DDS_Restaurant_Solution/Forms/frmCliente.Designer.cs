namespace DDS_Restaurant_Solution.Forms3
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.BackColor = System.Drawing.Color.White;
            this.BtnAñadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAñadir.BackgroundImage")));
            this.BtnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAñadir.Location = new System.Drawing.Point(700, 32);
            this.BtnAñadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(50, 36);
            this.BtnAñadir.TabIndex = 1;
            this.BtnAñadir.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.White;
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Location = new System.Drawing.Point(700, 81);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(50, 36);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.White;
            this.BtnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.BackgroundImage")));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Location = new System.Drawing.Point(700, 132);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(50, 36);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.UseVisualStyleBackColor = false;
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
            this.dgvMesas.Size = new System.Drawing.Size(672, 437);
            this.dgvMesas.TabIndex = 26;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 476);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAñadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.DataGridView dgvMesas;
    }
}