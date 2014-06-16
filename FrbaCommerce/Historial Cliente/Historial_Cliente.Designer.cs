namespace FrbaCommerce.Historial_Cliente
{
    partial class Historial_Cliente
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
            this.HistorialCompras = new System.Windows.Forms.Button();
            this.HistorialOfertas = new System.Windows.Forms.Button();
            this.HistorialCalificaciones = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HistorialCompras
            // 
            this.HistorialCompras.Location = new System.Drawing.Point(98, 12);
            this.HistorialCompras.Name = "HistorialCompras";
            this.HistorialCompras.Size = new System.Drawing.Size(97, 37);
            this.HistorialCompras.TabIndex = 4;
            this.HistorialCompras.Text = "Historial de compras";
            this.HistorialCompras.UseVisualStyleBackColor = true;
            this.HistorialCompras.Click += new System.EventHandler(this.HistorialCompras_Click);
            // 
            // HistorialOfertas
            // 
            this.HistorialOfertas.Location = new System.Drawing.Point(310, 12);
            this.HistorialOfertas.Name = "HistorialOfertas";
            this.HistorialOfertas.Size = new System.Drawing.Size(97, 37);
            this.HistorialOfertas.TabIndex = 5;
            this.HistorialOfertas.Text = "Historial de ofertas";
            this.HistorialOfertas.UseVisualStyleBackColor = true;
            this.HistorialOfertas.Click += new System.EventHandler(this.HistorialOfertas_Click);
            // 
            // HistorialCalificaciones
            // 
            this.HistorialCalificaciones.Location = new System.Drawing.Point(508, 12);
            this.HistorialCalificaciones.Name = "HistorialCalificaciones";
            this.HistorialCalificaciones.Size = new System.Drawing.Size(97, 37);
            this.HistorialCalificaciones.TabIndex = 6;
            this.HistorialCalificaciones.Text = "Historial de calificaciones";
            this.HistorialCalificaciones.UseVisualStyleBackColor = true;
            this.HistorialCalificaciones.Click += new System.EventHandler(this.HistorialCalificaciones_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(677, 295);
            this.dataGridView1.TabIndex = 7;
            // 
            // Historial_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HistorialCalificaciones);
            this.Controls.Add(this.HistorialOfertas);
            this.Controls.Add(this.HistorialCompras);
            this.Name = "Historial_Cliente";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HistorialCompras;
        private System.Windows.Forms.Button HistorialOfertas;
        private System.Windows.Forms.Button HistorialCalificaciones;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}