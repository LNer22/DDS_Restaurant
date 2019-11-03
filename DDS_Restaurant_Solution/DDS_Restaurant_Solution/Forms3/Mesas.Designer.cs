namespace DDS_Restaurant_Solution.Forms3
{
    partial class Mesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesas));
            this.DgvMesas = new System.Windows.Forms.DataGridView();
            this.ColumMesas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLiberar = new System.Windows.Forms.Button();
            this.BtnEliminarMesa = new System.Windows.Forms.Button();
            this.BtnAñadirMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMesas
            // 
            this.DgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumMesas,
            this.ColumCapacidad,
            this.ColumDisponible});
            this.DgvMesas.Location = new System.Drawing.Point(27, 21);
            this.DgvMesas.Name = "DgvMesas";
            this.DgvMesas.RowHeadersWidth = 51;
            this.DgvMesas.RowTemplate.Height = 24;
            this.DgvMesas.Size = new System.Drawing.Size(734, 577);
            this.DgvMesas.TabIndex = 0;
            // 
            // ColumMesas
            // 
            this.ColumMesas.HeaderText = "Mesa";
            this.ColumMesas.MinimumWidth = 6;
            this.ColumMesas.Name = "ColumMesas";
            this.ColumMesas.Width = 200;
            // 
            // ColumCapacidad
            // 
            this.ColumCapacidad.HeaderText = "Capacidad";
            this.ColumCapacidad.MinimumWidth = 6;
            this.ColumCapacidad.Name = "ColumCapacidad";
            this.ColumCapacidad.Width = 240;
            // 
            // ColumDisponible
            // 
            this.ColumDisponible.HeaderText = "Disponible";
            this.ColumDisponible.MinimumWidth = 6;
            this.ColumDisponible.Name = "ColumDisponible";
            this.ColumDisponible.Width = 240;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(794, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Liberar mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(817, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(817, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Añadir";
            // 
            // BtnLiberar
            // 
            this.BtnLiberar.BackColor = System.Drawing.Color.White;
            this.BtnLiberar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLiberar.BackgroundImage")));
            this.BtnLiberar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLiberar.Location = new System.Drawing.Point(813, 250);
            this.BtnLiberar.Name = "BtnLiberar";
            this.BtnLiberar.Size = new System.Drawing.Size(67, 44);
            this.BtnLiberar.TabIndex = 9;
            this.BtnLiberar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarMesa
            // 
            this.BtnEliminarMesa.BackColor = System.Drawing.Color.White;
            this.BtnEliminarMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarMesa.BackgroundImage")));
            this.BtnEliminarMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarMesa.Location = new System.Drawing.Point(813, 159);
            this.BtnEliminarMesa.Name = "BtnEliminarMesa";
            this.BtnEliminarMesa.Size = new System.Drawing.Size(67, 44);
            this.BtnEliminarMesa.TabIndex = 8;
            this.BtnEliminarMesa.UseVisualStyleBackColor = false;
            // 
            // BtnAñadirMesa
            // 
            this.BtnAñadirMesa.BackColor = System.Drawing.Color.White;
            this.BtnAñadirMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAñadirMesa.BackgroundImage")));
            this.BtnAñadirMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadirMesa.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAñadirMesa.Location = new System.Drawing.Point(813, 72);
            this.BtnAñadirMesa.Name = "BtnAñadirMesa";
            this.BtnAñadirMesa.Size = new System.Drawing.Size(67, 44);
            this.BtnAñadirMesa.TabIndex = 7;
            this.BtnAñadirMesa.UseVisualStyleBackColor = false;
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 625);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLiberar);
            this.Controls.Add(this.BtnEliminarMesa);
            this.Controls.Add(this.BtnAñadirMesa);
            this.Controls.Add(this.DgvMesas);
            this.Name = "Mesas";
            this.Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDisponible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLiberar;
        private System.Windows.Forms.Button BtnEliminarMesa;
        private System.Windows.Forms.Button BtnAñadirMesa;
    }
}