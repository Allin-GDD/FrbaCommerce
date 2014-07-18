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
            this.GenerarPubl = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.FacturarPublicaciones = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerarPubl
            // 
            this.GenerarPubl.Location = new System.Drawing.Point(12, 12);
            this.GenerarPubl.Name = "GenerarPubl";
            this.GenerarPubl.Size = new System.Drawing.Size(211, 52);
            this.GenerarPubl.TabIndex = 0;
            this.GenerarPubl.Text = "Generar Publicación";
            this.GenerarPubl.UseVisualStyleBackColor = true;
            this.GenerarPubl.Click += new System.EventHandler(this.GenerarPubl_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(50, 283);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(132, 22);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(12, 70);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(211, 41);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar Publicaciones";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // FacturarPublicaciones
            // 
            this.FacturarPublicaciones.Location = new System.Drawing.Point(12, 117);
            this.FacturarPublicaciones.Name = "FacturarPublicaciones";
            this.FacturarPublicaciones.Size = new System.Drawing.Size(88, 41);
            this.FacturarPublicaciones.TabIndex = 4;
            this.FacturarPublicaciones.Text = "Facturar Publicaciones";
            this.FacturarPublicaciones.UseVisualStyleBackColor = true;
            this.FacturarPublicaciones.Click += new System.EventHandler(this.FacturarPublicaciones_Click);
            // 
            // Historial
            // 
            this.Historial.Location = new System.Drawing.Point(12, 238);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(88, 29);
            this.Historial.TabIndex = 5;
            this.Historial.Text = "Historial";
            this.Historial.UseVisualStyleBackColor = true;
            this.Historial.Click += new System.EventHandler(this.Historial_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calificaciones Pendientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Editar Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Gestor de Preguntas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(135, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "Subastas Pendientes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Rol_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 327);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.FacturarPublicaciones);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.GenerarPubl);
            this.Name = "Rol_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione una opción";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerarPubl;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button FacturarPublicaciones;
        private System.Windows.Forms.Button Historial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}