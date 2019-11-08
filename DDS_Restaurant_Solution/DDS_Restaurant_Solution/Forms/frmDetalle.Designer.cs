namespace DDS_Restaurant_Solution.Forms
{
    partial class frmDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEditarDetalle = new System.Windows.Forms.Button();
            this.BtnEliminarDetalle = new System.Windows.Forms.Button();
            this.BtnAñadirDetallle = new System.Windows.Forms.Button();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditarDetalle
            // 
            this.BtnEditarDetalle.BackColor = System.Drawing.Color.White;
            this.BtnEditarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditarDetalle.BackgroundImage")));
            this.BtnEditarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditarDetalle.Location = new System.Drawing.Point(627, 84);
            this.BtnEditarDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEditarDetalle.Name = "BtnEditarDetalle";
            this.BtnEditarDetalle.Size = new System.Drawing.Size(50, 36);
            this.BtnEditarDetalle.TabIndex = 9;
            this.BtnEditarDetalle.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarDetalle
            // 
            this.BtnEliminarDetalle.BackColor = System.Drawing.Color.White;
            this.BtnEliminarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarDetalle.BackgroundImage")));
            this.BtnEliminarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarDetalle.Location = new System.Drawing.Point(627, 44);
            this.BtnEliminarDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminarDetalle.Name = "BtnEliminarDetalle";
            this.BtnEliminarDetalle.Size = new System.Drawing.Size(50, 36);
            this.BtnEliminarDetalle.TabIndex = 8;
            this.BtnEliminarDetalle.UseVisualStyleBackColor = false;
            // 
            // BtnAñadirDetallle
            // 
            this.BtnAñadirDetallle.BackColor = System.Drawing.Color.White;
            this.BtnAñadirDetallle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAñadirDetallle.BackgroundImage")));
            this.BtnAñadirDetallle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadirDetallle.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAñadirDetallle.Location = new System.Drawing.Point(627, 3);
            this.BtnAñadirDetallle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAñadirDetallle.Name = "BtnAñadirDetallle";
            this.BtnAñadirDetallle.Size = new System.Drawing.Size(50, 36);
            this.BtnAñadirDetallle.TabIndex = 7;
            this.BtnAñadirDetallle.UseVisualStyleBackColor = false;
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
            this.dgvMesas.Location = new System.Drawing.Point(23, 7);
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
            this.dgvMesas.Size = new System.Drawing.Size(598, 383);
            this.dgvMesas.TabIndex = 16;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.BtnEditarDetalle);
            this.Controls.Add(this.BtnEliminarDetalle);
            this.Controls.Add(this.BtnAñadirDetallle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDetalle";
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEditarDetalle;
        private System.Windows.Forms.Button BtnEliminarDetalle;
        private System.Windows.Forms.Button BtnAñadirDetallle;
        private System.Windows.Forms.DataGridView dgvMesas;
    }
}