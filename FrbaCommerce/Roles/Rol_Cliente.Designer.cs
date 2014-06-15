namespace FrbaCommerce.Roles
{
    partial class Rol_Cliente
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
            this.PublicarSubasta = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.PublicarCompraInmediata = new System.Windows.Forms.Button();
            this.FacturarPublicaciones = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PublicarSubasta
            // 
            this.PublicarSubasta.Location = new System.Drawing.Point(13, 23);
            this.PublicarSubasta.Name = "PublicarSubasta";
            this.PublicarSubasta.Size = new System.Drawing.Size(88, 52);
            this.PublicarSubasta.TabIndex = 0;
            this.PublicarSubasta.Text = "Publicar Subasta";
            this.PublicarSubasta.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(78, 235);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(88, 33);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(13, 177);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(88, 41);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // PublicarCompraInmediata
            // 
            this.PublicarCompraInmediata.Location = new System.Drawing.Point(136, 23);
            this.PublicarCompraInmediata.Name = "PublicarCompraInmediata";
            this.PublicarCompraInmediata.Size = new System.Drawing.Size(94, 52);
            this.PublicarCompraInmediata.TabIndex = 3;
            this.PublicarCompraInmediata.Text = "Publicar Compra Inmediata";
            this.PublicarCompraInmediata.UseVisualStyleBackColor = true;
            // 
            // FacturarPublicaciones
            // 
            this.FacturarPublicaciones.Location = new System.Drawing.Point(14, 109);
            this.FacturarPublicaciones.Name = "FacturarPublicaciones";
            this.FacturarPublicaciones.Size = new System.Drawing.Size(87, 36);
            this.FacturarPublicaciones.TabIndex = 4;
            this.FacturarPublicaciones.Text = "Facturar Publicaciones";
            this.FacturarPublicaciones.UseVisualStyleBackColor = true;
            // 
            // Historial
            // 
            this.Historial.Location = new System.Drawing.Point(136, 109);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(88, 36);
            this.Historial.TabIndex = 5;
            this.Historial.Text = "Historial";
            this.Historial.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calificaciones Pendientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rol_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.FacturarPublicaciones);
            this.Controls.Add(this.PublicarCompraInmediata);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.PublicarSubasta);
            this.Name = "Rol_Cliente";
            this.Text = "Seleccione una opción";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PublicarSubasta;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button PublicarCompraInmediata;
        private System.Windows.Forms.Button FacturarPublicaciones;
        private System.Windows.Forms.Button Historial;
        private System.Windows.Forms.Button button1;
    }
}