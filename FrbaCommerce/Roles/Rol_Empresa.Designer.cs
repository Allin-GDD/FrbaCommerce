﻿namespace FrbaCommerce.Roles
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
            this.PublicarSubasta = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.PublicarCompraInmediata = new System.Windows.Forms.Button();
            this.FacturarPublicaciones = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PublicarSubasta
            // 
            this.PublicarSubasta.Location = new System.Drawing.Point(23, 50);
            this.PublicarSubasta.Name = "PublicarSubasta";
            this.PublicarSubasta.Size = new System.Drawing.Size(97, 42);
            this.PublicarSubasta.TabIndex = 0;
            this.PublicarSubasta.Text = "Publicar Subasta";
            this.PublicarSubasta.UseVisualStyleBackColor = true;
            this.PublicarSubasta.Click += new System.EventHandler(this.Publicar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(166, 224);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(93, 26);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // PublicarCompraInmediata
            // 
            this.PublicarCompraInmediata.Location = new System.Drawing.Point(166, 50);
            this.PublicarCompraInmediata.Name = "PublicarCompraInmediata";
            this.PublicarCompraInmediata.Size = new System.Drawing.Size(97, 43);
            this.PublicarCompraInmediata.TabIndex = 2;
            this.PublicarCompraInmediata.Text = "Publicar Compra Inmediata";
            this.PublicarCompraInmediata.UseVisualStyleBackColor = true;
            this.PublicarCompraInmediata.Click += new System.EventHandler(this.PublicarCompraInmediata_Click);
            // 
            // FacturarPublicaciones
            // 
            this.FacturarPublicaciones.Location = new System.Drawing.Point(23, 137);
            this.FacturarPublicaciones.Name = "FacturarPublicaciones";
            this.FacturarPublicaciones.Size = new System.Drawing.Size(97, 37);
            this.FacturarPublicaciones.TabIndex = 3;
            this.FacturarPublicaciones.Text = "Facturar Publicaciones";
            this.FacturarPublicaciones.UseVisualStyleBackColor = true;
            // 
            // Historial
            // 
            this.Historial.Location = new System.Drawing.Point(166, 137);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(97, 37);
            this.Historial.TabIndex = 4;
            this.Historial.Text = "Historial";
            this.Historial.UseVisualStyleBackColor = true;
            // 
            // Rol_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.FacturarPublicaciones);
            this.Controls.Add(this.PublicarCompraInmediata);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.PublicarSubasta);
            this.Name = "Rol_Empresa";
            this.Text = "Seleccione una opción";
            this.Load += new System.EventHandler(this.Rol_Empresa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PublicarSubasta;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button PublicarCompraInmediata;
        private System.Windows.Forms.Button FacturarPublicaciones;
        private System.Windows.Forms.Button Historial;
    }
}