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
            this.DgvPedido = new System.Windows.Forms.DataGridView();
            this.ColumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPedidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumEstadoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditarPedido = new System.Windows.Forms.Button();
            this.BtnEliminarPedido = new System.Windows.Forms.Button();
            this.BtnAñadirPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPedido
            // 
            this.DgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumPedido,
            this.ColumHH,
            this.ColumPedidoCliente,
            this.ColumEstadoPedido,
            this.ColumMesa,
            this.ColumDetalle});
            this.DgvPedido.Location = new System.Drawing.Point(12, 12);
            this.DgvPedido.Name = "DgvPedido";
            this.DgvPedido.RowHeadersWidth = 51;
            this.DgvPedido.RowTemplate.Height = 24;
            this.DgvPedido.Size = new System.Drawing.Size(981, 538);
            this.DgvPedido.TabIndex = 0;
            // 
            // ColumPedido
            // 
            this.ColumPedido.HeaderText = "Pedido N°";
            this.ColumPedido.MinimumWidth = 6;
            this.ColumPedido.Name = "ColumPedido";
            this.ColumPedido.Width = 110;
            // 
            // ColumHH
            // 
            this.ColumHH.HeaderText = "HH";
            this.ColumHH.MinimumWidth = 6;
            this.ColumHH.Name = "ColumHH";
            // 
            // ColumPedidoCliente
            // 
            this.ColumPedidoCliente.HeaderText = "Cliente";
            this.ColumPedidoCliente.MinimumWidth = 6;
            this.ColumPedidoCliente.Name = "ColumPedidoCliente";
            this.ColumPedidoCliente.Width = 240;
            // 
            // ColumEstadoPedido
            // 
            this.ColumEstadoPedido.HeaderText = "Estado";
            this.ColumEstadoPedido.MinimumWidth = 6;
            this.ColumEstadoPedido.Name = "ColumEstadoPedido";
            this.ColumEstadoPedido.Width = 150;
            // 
            // ColumMesa
            // 
            this.ColumMesa.HeaderText = "Mesa N°";
            this.ColumMesa.MinimumWidth = 6;
            this.ColumMesa.Name = "ColumMesa";
            this.ColumMesa.Width = 125;
            // 
            // ColumDetalle
            // 
            this.ColumDetalle.HeaderText = "Detalle";
            this.ColumDetalle.MinimumWidth = 6;
            this.ColumDetalle.Name = "ColumDetalle";
            this.ColumDetalle.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1071, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Editar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1067, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1067, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Añadir";
            // 
            // BtnEditarPedido
            // 
            this.BtnEditarPedido.BackColor = System.Drawing.Color.White;
            this.BtnEditarPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditarPedido.BackgroundImage")));
            this.BtnEditarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditarPedido.Location = new System.Drawing.Point(1063, 246);
            this.BtnEditarPedido.Name = "BtnEditarPedido";
            this.BtnEditarPedido.Size = new System.Drawing.Size(67, 44);
            this.BtnEditarPedido.TabIndex = 9;
            this.BtnEditarPedido.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarPedido
            // 
            this.BtnEliminarPedido.BackColor = System.Drawing.Color.White;
            this.BtnEliminarPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarPedido.BackgroundImage")));
            this.BtnEliminarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarPedido.Location = new System.Drawing.Point(1063, 155);
            this.BtnEliminarPedido.Name = "BtnEliminarPedido";
            this.BtnEliminarPedido.Size = new System.Drawing.Size(67, 44);
            this.BtnEliminarPedido.TabIndex = 8;
            this.BtnEliminarPedido.UseVisualStyleBackColor = false;
            // 
            // BtnAñadirPedido
            // 
            this.BtnAñadirPedido.BackColor = System.Drawing.Color.White;
            this.BtnAñadirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAñadirPedido.BackgroundImage")));
            this.BtnAñadirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadirPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAñadirPedido.Location = new System.Drawing.Point(1063, 68);
            this.BtnAñadirPedido.Name = "BtnAñadirPedido";
            this.BtnAñadirPedido.Size = new System.Drawing.Size(67, 44);
            this.BtnAñadirPedido.TabIndex = 7;
            this.BtnAñadirPedido.UseVisualStyleBackColor = false;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEditarPedido);
            this.Controls.Add(this.BtnEliminarPedido);
            this.Controls.Add(this.BtnAñadirPedido);
            this.Controls.Add(this.DgvPedido);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPedidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumEstadoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEditarPedido;
        private System.Windows.Forms.Button BtnEliminarPedido;
        private System.Windows.Forms.Button BtnAñadirPedido;
    }
}