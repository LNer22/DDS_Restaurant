namespace DDS_Restaurant_Solution.Forms3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesasOrdenes));
            this.DgvMesasDispo = new System.Windows.Forms.DataGridView();
            this.ColumnMesa1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDispo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCombinar = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnParallevar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMesasDispo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMesasDispo
            // 
            this.DgvMesasDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMesasDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMesa1,
            this.ColumDispo});
            this.DgvMesasDispo.Location = new System.Drawing.Point(20, 23);
            this.DgvMesasDispo.Name = "DgvMesasDispo";
            this.DgvMesasDispo.RowHeadersWidth = 51;
            this.DgvMesasDispo.RowTemplate.Height = 24;
            this.DgvMesasDispo.Size = new System.Drawing.Size(625, 620);
            this.DgvMesasDispo.TabIndex = 0;
            // 
            // ColumnMesa1
            // 
            this.ColumnMesa1.HeaderText = "Mesas";
            this.ColumnMesa1.MinimumWidth = 6;
            this.ColumnMesa1.Name = "ColumnMesa1";
            this.ColumnMesa1.Width = 170;
            // 
            // ColumDispo
            // 
            this.ColumDispo.HeaderText = "Disponibilidad";
            this.ColumDispo.MinimumWidth = 6;
            this.ColumDispo.Name = "ColumDispo";
            this.ColumDispo.Width = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Combinar Mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(719, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imprimir Cuenta";
            // 
            // BtnCombinar
            // 
            this.BtnCombinar.BackColor = System.Drawing.Color.White;
            this.BtnCombinar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCombinar.BackgroundImage")));
            this.BtnCombinar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCombinar.Location = new System.Drawing.Point(743, 252);
            this.BtnCombinar.Name = "BtnCombinar";
            this.BtnCombinar.Size = new System.Drawing.Size(67, 44);
            this.BtnCombinar.TabIndex = 9;
            this.BtnCombinar.UseVisualStyleBackColor = false;
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackColor = System.Drawing.Color.White;
            this.BtnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPagar.BackgroundImage")));
            this.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPagar.Location = new System.Drawing.Point(743, 161);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(67, 44);
            this.BtnPagar.TabIndex = 8;
            this.BtnPagar.UseVisualStyleBackColor = false;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.White;
            this.BtnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.BackgroundImage")));
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnImprimir.Location = new System.Drawing.Point(743, 74);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(67, 44);
            this.BtnImprimir.TabIndex = 7;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Para llevar";
            // 
            // BtnParallevar
            // 
            this.BtnParallevar.BackColor = System.Drawing.Color.White;
            this.BtnParallevar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnParallevar.BackgroundImage")));
            this.BtnParallevar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnParallevar.Location = new System.Drawing.Point(743, 335);
            this.BtnParallevar.Name = "BtnParallevar";
            this.BtnParallevar.Size = new System.Drawing.Size(67, 44);
            this.BtnParallevar.TabIndex = 13;
            this.BtnParallevar.UseVisualStyleBackColor = false;
            // 
            // Mesas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 670);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnParallevar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCombinar);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.DgvMesasDispo);
            this.Name = "Mesas2";
            this.Text = "Mesas2";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMesasDispo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMesasDispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMesa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDispo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCombinar;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnParallevar;
    }
}