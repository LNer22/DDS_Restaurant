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
            this.DgvRegistroCliente = new System.Windows.Forms.DataGridView();
            this.ColumNumIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTelef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRegistroCliente
            // 
            this.DgvRegistroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistroCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNumIdentidad,
            this.ColumNombre,
            this.ColumTelef,
            this.ColumCorreo,
            this.ColumGen});
            this.DgvRegistroCliente.Location = new System.Drawing.Point(12, 12);
            this.DgvRegistroCliente.Name = "DgvRegistroCliente";
            this.DgvRegistroCliente.RowHeadersWidth = 51;
            this.DgvRegistroCliente.RowTemplate.Height = 24;
            this.DgvRegistroCliente.Size = new System.Drawing.Size(1033, 543);
            this.DgvRegistroCliente.TabIndex = 0;
            // 
            // ColumNumIdentidad
            // 
            this.ColumNumIdentidad.HeaderText = "NumIdentidad";
            this.ColumNumIdentidad.MinimumWidth = 9;
            this.ColumNumIdentidad.Name = "ColumNumIdentidad";
            this.ColumNumIdentidad.Width = 170;
            // 
            // ColumNombre
            // 
            this.ColumNombre.HeaderText = "NombreCompleto";
            this.ColumNombre.MinimumWidth = 6;
            this.ColumNombre.Name = "ColumNombre";
            this.ColumNombre.Width = 300;
            // 
            // ColumTelef
            // 
            this.ColumTelef.HeaderText = "NumTelefono";
            this.ColumTelef.MinimumWidth = 6;
            this.ColumTelef.Name = "ColumTelef";
            this.ColumTelef.Width = 140;
            // 
            // ColumCorreo
            // 
            this.ColumCorreo.HeaderText = "Correo";
            this.ColumCorreo.MinimumWidth = 6;
            this.ColumCorreo.Name = "ColumCorreo";
            this.ColumCorreo.Width = 220;
            // 
            // ColumGen
            // 
            this.ColumGen.HeaderText = "Genero";
            this.ColumGen.MinimumWidth = 6;
            this.ColumGen.Name = "ColumGen";
            this.ColumGen.Width = 150;
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.BackColor = System.Drawing.Color.White;
            this.BtnAñadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAñadir.BackgroundImage")));
            this.BtnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAñadir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAñadir.Location = new System.Drawing.Point(1094, 62);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(67, 44);
            this.BtnAñadir.TabIndex = 1;
            this.BtnAñadir.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.White;
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Location = new System.Drawing.Point(1094, 149);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(67, 44);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.White;
            this.BtnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.BackgroundImage")));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Location = new System.Drawing.Point(1094, 240);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(67, 44);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1098, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Añadir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1098, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eliminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1102, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Editar";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAñadir);
            this.Controls.Add(this.DgvRegistroCliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistroCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRegistroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNumIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTelef;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumGen;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}