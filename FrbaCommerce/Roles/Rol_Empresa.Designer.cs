namespace FrbaCommerce.Roles
{
    partial class Rol_Empresa
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
            this.GnerarPubl = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.FacturarPublicaciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GnerarPubl
            // 
            this.GnerarPubl.Location = new System.Drawing.Point(12, 21);
            this.GnerarPubl.Name = "GnerarPubl";
            this.GnerarPubl.Size = new System.Drawing.Size(215, 42);
            this.GnerarPubl.TabIndex = 0;
            this.GnerarPubl.Text = "Generar Publicación";
            this.GnerarPubl.UseVisualStyleBackColor = true;
            this.GnerarPubl.Click += new System.EventHandler(this.GnerarPubl_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(39, 165);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(154, 23);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // FacturarPublicaciones
            // 
            this.FacturarPublicaciones.Location = new System.Drawing.Point(12, 79);
            this.FacturarPublicaciones.Name = "FacturarPublicaciones";
            this.FacturarPublicaciones.Size = new System.Drawing.Size(97, 37);
            this.FacturarPublicaciones.TabIndex = 3;
            this.FacturarPublicaciones.Text = "Facturar Publicaciones";
            this.FacturarPublicaciones.UseVisualStyleBackColor = true;
            this.FacturarPublicaciones.Click += new System.EventHandler(this.FacturarPublicaciones_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Editar Publicaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Editar Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rol_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 204);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FacturarPublicaciones);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.GnerarPubl);
            this.Name = "Rol_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione una opción";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GnerarPubl;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button FacturarPublicaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}