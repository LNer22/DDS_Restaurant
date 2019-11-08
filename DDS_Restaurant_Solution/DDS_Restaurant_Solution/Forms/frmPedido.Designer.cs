namespace DDS_Restaurant_Solution.Forms3
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEditarPedido = new System.Windows.Forms.Button();
            this.BtnEliminarPedido = new System.Windows.Forms.Button();
            this.BtnAñadirPedido = new System.Windows.Forms.Button();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditarPedido
            // 
            this.BtnEditarPedido.BackColor = System.Drawing.Color.White;
            this.BtnEditarPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditarPedido.BackgroundImage")));
            this.BtnEditarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditarPedido.Location = new System.Drawing.Point(698, 87);
            this.BtnEditarPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEditarPedido.Name = "BtnEditarPedido";
            this.BtnEditarPedido.Size = new System.Drawing.Size(50, 36);
            this.BtnEditarPedido.TabIndex = 9;
            this.BtnEditarPedido.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarPedido
            // 
            this.BtnEliminarPedido.BackColor = System.Drawing.Color.White;
            this.BtnEliminarPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarPedido.BackgroundImage")));
            this.BtnEliminarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarPedido.Location = new System.Drawing.Point(698, 45);
            this.BtnEliminarPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminarPedido.Name = "BtnEliminarPedido";
            this.BtnEliminarPedido.Size = new System.Drawing.Size(50, 36);
            this.BtnEliminarPedido.TabIndex = 8;
            this.BtnEliminarPedido.UseVisualStyleBackColor = false;
            // 
            // BtnAñadirPedido
            // 
            this.BtnAñadirPedido.BackColor = System.Drawing.Color.White;
            this.BtnAñadirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAñadirPedido.BackgroundImage")));
            this.BtnAñadirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadirPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAñadirPedido.Location = new System.Drawing.Point(698, 5);
            this.BtnAñadirPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAñadirPedido.Name = "BtnAñadirPedido";
            this.BtnAñadirPedido.Size = new System.Drawing.Size(50, 36);
            this.BtnAñadirPedido.TabIndex = 7;
            this.BtnAñadirPedido.UseVisualStyleBackColor = false;
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
            this.dgvMesas.Location = new System.Drawing.Point(21, 8);
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
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 457);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.BtnEditarPedido);
            this.Controls.Add(this.BtnEliminarPedido);
            this.Controls.Add(this.BtnAñadirPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEditarPedido;
        private System.Windows.Forms.Button BtnEliminarPedido;
        private System.Windows.Forms.Button BtnAñadirPedido;
        private System.Windows.Forms.DataGridView dgvMesas;
    }
}