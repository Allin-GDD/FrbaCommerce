namespace FrbaCommerce.Roles
{
    partial class Rol_Admin
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
            this.AbmCliente = new System.Windows.Forms.Button();
            this.AbmEmpresa = new System.Windows.Forms.Button();
            this.ListadoEstadistico = new System.Windows.Forms.Button();
            this.AbmRubro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbmCliente
            // 
            this.AbmCliente.Location = new System.Drawing.Point(12, 31);
            this.AbmCliente.Name = "AbmCliente";
            this.AbmCliente.Size = new System.Drawing.Size(97, 39);
            this.AbmCliente.TabIndex = 0;
            this.AbmCliente.Text = "Abm Cliente";
            this.AbmCliente.UseVisualStyleBackColor = true;
            this.AbmCliente.Click += new System.EventHandler(this.AbmCliente_Click);
            // 
            // AbmEmpresa
            // 
            this.AbmEmpresa.Location = new System.Drawing.Point(160, 31);
            this.AbmEmpresa.Name = "AbmEmpresa";
            this.AbmEmpresa.Size = new System.Drawing.Size(98, 39);
            this.AbmEmpresa.TabIndex = 1;
            this.AbmEmpresa.Text = "Abm Empresa";
            this.AbmEmpresa.UseVisualStyleBackColor = true;
            this.AbmEmpresa.Click += new System.EventHandler(this.AbmEmpresa_Click);
            // 
            // ListadoEstadistico
            // 
            this.ListadoEstadistico.Location = new System.Drawing.Point(12, 163);
            this.ListadoEstadistico.Name = "ListadoEstadistico";
            this.ListadoEstadistico.Size = new System.Drawing.Size(97, 34);
            this.ListadoEstadistico.TabIndex = 2;
            this.ListadoEstadistico.Text = "Listado Estadístico";
            this.ListadoEstadistico.UseVisualStyleBackColor = true;
            // 
            // AbmRubro
            // 
            this.AbmRubro.Location = new System.Drawing.Point(160, 100);
            this.AbmRubro.Name = "AbmRubro";
            this.AbmRubro.Size = new System.Drawing.Size(98, 34);
            this.AbmRubro.TabIndex = 3;
            this.AbmRubro.Text = "Abm Rol";
            this.AbmRubro.UseVisualStyleBackColor = true;
            this.AbmRubro.Click += new System.EventHandler(this.AbmRubro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Abm Visibilidad Publicación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(160, 227);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(97, 23);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Rol_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AbmRubro);
            this.Controls.Add(this.ListadoEstadistico);
            this.Controls.Add(this.AbmEmpresa);
            this.Controls.Add(this.AbmCliente);
            this.Name = "Rol_Admin";
            this.Text = "Usuario: Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AbmCliente;
        private System.Windows.Forms.Button AbmEmpresa;
        private System.Windows.Forms.Button ListadoEstadistico;
        private System.Windows.Forms.Button AbmRubro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Salir;
    }
}