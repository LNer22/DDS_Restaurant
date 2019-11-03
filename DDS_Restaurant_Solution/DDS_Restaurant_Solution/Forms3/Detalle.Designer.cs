namespace DDS_Restaurant_Solution.Forms3
{
    partial class Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle));
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.ColumNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditarDetalle = new System.Windows.Forms.Button();
            this.BtnEliminarDetalle = new System.Windows.Forms.Button();
            this.BtnAñadirDetallle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNum,
            this.ColumNombre,
            this.ColumDescripcion,
            this.ColumTipo,
            this.Column5});
            this.DgvDetalle.Location = new System.Drawing.Point(11, 15);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.RowHeadersWidth = 51;
            this.DgvDetalle.RowTemplate.Height = 24;
            this.DgvDetalle.Size = new System.Drawing.Size(934, 697);
            this.DgvDetalle.TabIndex = 0;
            // 
            // ColumNum
            // 
            this.ColumNum.HeaderText = "N°";
            this.ColumNum.MinimumWidth = 6;
            this.ColumNum.Name = "ColumNum";
            this.ColumNum.Width = 80;
            // 
            // ColumNombre
            // 
            this.ColumNombre.HeaderText = "Nombre";
            this.ColumNombre.MinimumWidth = 6;
            this.ColumNombre.Name = "ColumNombre";
            this.ColumNombre.Width = 230;
            // 
            // ColumDescripcion
            // 
            this.ColumDescripcion.HeaderText = "Descripción";
            this.ColumDescripcion.MinimumWidth = 6;
            this.ColumDescripcion.Name = "ColumDescripcion";
            this.ColumDescripcion.Width = 220;
            // 
            // ColumTipo
            // 
            this.ColumTipo.HeaderText = "Tipo";
            this.ColumTipo.MinimumWidth = 6;
            this.ColumTipo.Name = "ColumTipo";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de creacion";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1013, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Editar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1009, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1009, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Añadir";
            // 
            // BtnEditarDetalle
            // 
            this.BtnEditarDetalle.BackColor = System.Drawing.Color.White;
            this.BtnEditarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditarDetalle.BackgroundImage")));
            this.BtnEditarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditarDetalle.Location = new System.Drawing.Point(1005, 245);
            this.BtnEditarDetalle.Name = "BtnEditarDetalle";
            this.BtnEditarDetalle.Size = new System.Drawing.Size(66, 44);
            this.BtnEditarDetalle.TabIndex = 9;
            this.BtnEditarDetalle.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarDetalle
            // 
            this.BtnEliminarDetalle.BackColor = System.Drawing.Color.White;
            this.BtnEliminarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarDetalle.BackgroundImage")));
            this.BtnEliminarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarDetalle.Location = new System.Drawing.Point(1005, 154);
            this.BtnEliminarDetalle.Name = "BtnEliminarDetalle";
            this.BtnEliminarDetalle.Size = new System.Drawing.Size(66, 44);
            this.BtnEliminarDetalle.TabIndex = 8;
            this.BtnEliminarDetalle.UseVisualStyleBackColor = false;
            // 
            // BtnAñadirDetallle
            // 
            this.BtnAñadirDetallle.BackColor = System.Drawing.Color.White;
            this.BtnAñadirDetallle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAñadirDetallle.BackgroundImage")));
            this.BtnAñadirDetallle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadirDetallle.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAñadirDetallle.Location = new System.Drawing.Point(1005, 67);
            this.BtnAñadirDetallle.Name = "BtnAñadirDetallle";
            this.BtnAñadirDetallle.Size = new System.Drawing.Size(66, 44);
            this.BtnAñadirDetallle.TabIndex = 7;
            this.BtnAñadirDetallle.UseVisualStyleBackColor = false;
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEditarDetalle);
            this.Controls.Add(this.BtnEliminarDetalle);
            this.Controls.Add(this.BtnAñadirDetallle);
            this.Controls.Add(this.DgvDetalle);
            this.Name = "Detalle";
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEditarDetalle;
        private System.Windows.Forms.Button BtnEliminarDetalle;
        private System.Windows.Forms.Button BtnAñadirDetallle;
    }
}