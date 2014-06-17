namespace FrbaCommerce.Abm_Empresa
{
    partial class Baja
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CUIT = new System.Windows.Forms.MaskedTextBox();
            this.CodPostal = new System.Windows.Forms.MaskedTextBox();
            this.Telefono = new System.Windows.Forms.MaskedTextBox();
            this.labelNCalle = new System.Windows.Forms.Label();
            this.NCalle = new System.Windows.Forms.TextBox();
            this.labelFCreacion = new System.Windows.Forms.Label();
            this.Ciudad = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.FecCre = new System.Windows.Forms.MaskedTextBox();
            this.labelCP = new System.Windows.Forms.Label();
            this.Dpto = new System.Windows.Forms.TextBox();
            this.labelDpto = new System.Windows.Forms.Label();
            this.Localidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.NroPiso = new System.Windows.Forms.TextBox();
            this.labelNPiso = new System.Windows.Forms.Label();
            this.Calle = new System.Windows.Forms.TextBox();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.RazonSocial = new System.Windows.Forms.TextBox();
            this.labelRZ = new System.Windows.Forms.Label();
            this.NombreContacto = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "¿Está seguro que desea eliminar la empresa?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(72, 84);
            this.CUIT.Mask = "00-00000000-00";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.Size = new System.Drawing.Size(186, 20);
            this.CUIT.TabIndex = 31;
            // 
            // CodPostal
            // 
            this.CodPostal.Enabled = false;
            this.CodPostal.Location = new System.Drawing.Point(88, 273);
            this.CodPostal.Mask = "0000";
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.ReadOnly = true;
            this.CodPostal.Size = new System.Drawing.Size(170, 20);
            this.CodPostal.TabIndex = 39;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(72, 142);
            this.Telefono.Mask = "000-0000-0000";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Size = new System.Drawing.Size(186, 20);
            this.Telefono.TabIndex = 33;
            // 
            // labelNCalle
            // 
            this.labelNCalle.AutoSize = true;
            this.labelNCalle.Location = new System.Drawing.Point(21, 198);
            this.labelNCalle.Name = "labelNCalle";
            this.labelNCalle.Size = new System.Drawing.Size(50, 13);
            this.labelNCalle.TabIndex = 48;
            this.labelNCalle.Text = "Nro Calle";
            // 
            // NCalle
            // 
            this.NCalle.Enabled = false;
            this.NCalle.Location = new System.Drawing.Point(77, 196);
            this.NCalle.Name = "NCalle";
            this.NCalle.ReadOnly = true;
            this.NCalle.Size = new System.Drawing.Size(182, 20);
            this.NCalle.TabIndex = 35;
            // 
            // labelFCreacion
            // 
            this.labelFCreacion.AutoSize = true;
            this.labelFCreacion.Location = new System.Drawing.Point(21, 328);
            this.labelFCreacion.Name = "labelFCreacion";
            this.labelFCreacion.Size = new System.Drawing.Size(96, 13);
            this.labelFCreacion.TabIndex = 54;
            this.labelFCreacion.Text = "Fecha de creación";
            // 
            // Ciudad
            // 
            this.Ciudad.Enabled = false;
            this.Ciudad.Location = new System.Drawing.Point(76, 301);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Size = new System.Drawing.Size(182, 20);
            this.Ciudad.TabIndex = 40;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(21, 304);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 13);
            this.labelCiudad.TabIndex = 53;
            this.labelCiudad.Text = "Ciudad";
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Location = new System.Drawing.Point(21, 87);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(32, 13);
            this.labelCUIT.TabIndex = 44;
            this.labelCUIT.Text = "CUIT";
            // 
            // FecCre
            // 
            this.FecCre.Enabled = false;
            this.FecCre.Location = new System.Drawing.Point(129, 325);
            this.FecCre.Mask = "00/00/0000";
            this.FecCre.Name = "FecCre";
            this.FecCre.ReadOnly = true;
            this.FecCre.Size = new System.Drawing.Size(129, 20);
            this.FecCre.TabIndex = 41;
            this.FecCre.ValidatingType = typeof(System.DateTime);
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(21, 277);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(61, 13);
            this.labelCP.TabIndex = 52;
            this.labelCP.Text = "Cód. Postal";
            // 
            // Dpto
            // 
            this.Dpto.Enabled = false;
            this.Dpto.Location = new System.Drawing.Point(184, 221);
            this.Dpto.Name = "Dpto";
            this.Dpto.ReadOnly = true;
            this.Dpto.Size = new System.Drawing.Size(74, 20);
            this.Dpto.TabIndex = 37;
            // 
            // labelDpto
            // 
            this.labelDpto.AutoSize = true;
            this.labelDpto.Location = new System.Drawing.Point(148, 225);
            this.labelDpto.Name = "labelDpto";
            this.labelDpto.Size = new System.Drawing.Size(30, 13);
            this.labelDpto.TabIndex = 50;
            this.labelDpto.Text = "Dpto";
            // 
            // Localidad
            // 
            this.Localidad.Enabled = false;
            this.Localidad.Location = new System.Drawing.Point(76, 247);
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Size = new System.Drawing.Size(182, 20);
            this.Localidad.TabIndex = 38;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(21, 251);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(53, 13);
            this.labelLocalidad.TabIndex = 51;
            this.labelLocalidad.Text = "Localidad";
            // 
            // NroPiso
            // 
            this.NroPiso.Enabled = false;
            this.NroPiso.Location = new System.Drawing.Point(76, 222);
            this.NroPiso.Name = "NroPiso";
            this.NroPiso.ReadOnly = true;
            this.NroPiso.Size = new System.Drawing.Size(57, 20);
            this.NroPiso.TabIndex = 36;
            // 
            // labelNPiso
            // 
            this.labelNPiso.AutoSize = true;
            this.labelNPiso.Location = new System.Drawing.Point(21, 225);
            this.labelNPiso.Name = "labelNPiso";
            this.labelNPiso.Size = new System.Drawing.Size(47, 13);
            this.labelNPiso.TabIndex = 49;
            this.labelNPiso.Text = "Nro Piso";
            // 
            // Calle
            // 
            this.Calle.Enabled = false;
            this.Calle.Location = new System.Drawing.Point(76, 170);
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Size = new System.Drawing.Size(182, 20);
            this.Calle.TabIndex = 34;
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(21, 173);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(49, 13);
            this.labelCalle.TabIndex = 47;
            this.labelCalle.Text = "Domicilio";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(21, 145);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 13);
            this.labelTel.TabIndex = 46;
            this.labelTel.Text = "Teléfono";
            // 
            // Mail
            // 
            this.Mail.Enabled = false;
            this.Mail.Location = new System.Drawing.Point(72, 113);
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Size = new System.Drawing.Size(186, 20);
            this.Mail.TabIndex = 32;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(21, 116);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 45;
            this.labelMail.Text = "Mail";
            // 
            // RazonSocial
            // 
            this.RazonSocial.Enabled = false;
            this.RazonSocial.Location = new System.Drawing.Point(96, 56);
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Size = new System.Drawing.Size(162, 20);
            this.RazonSocial.TabIndex = 30;
            // 
            // labelRZ
            // 
            this.labelRZ.AutoSize = true;
            this.labelRZ.Location = new System.Drawing.Point(21, 59);
            this.labelRZ.Name = "labelRZ";
            this.labelRZ.Size = new System.Drawing.Size(70, 13);
            this.labelRZ.TabIndex = 43;
            this.labelRZ.Text = "Razón Social";
            // 
            // NombreContacto
            // 
            this.NombreContacto.Enabled = false;
            this.NombreContacto.Location = new System.Drawing.Point(131, 30);
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.ReadOnly = true;
            this.NombreContacto.Size = new System.Drawing.Size(127, 20);
            this.NombreContacto.TabIndex = 29;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(21, 33);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(104, 13);
            this.labelContacto.TabIndex = 42;
            this.labelContacto.Text = "Nombre de contacto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CUIT);
            this.Controls.Add(this.CodPostal);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.labelNCalle);
            this.Controls.Add(this.NCalle);
            this.Controls.Add(this.labelFCreacion);
            this.Controls.Add(this.Ciudad);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelCUIT);
            this.Controls.Add(this.FecCre);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.Dpto);
            this.Controls.Add(this.labelDpto);
            this.Controls.Add(this.Localidad);
            this.Controls.Add(this.labelLocalidad);
            this.Controls.Add(this.NroPiso);
            this.Controls.Add(this.labelNPiso);
            this.Controls.Add(this.Calle);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.RazonSocial);
            this.Controls.Add(this.labelRZ);
            this.Controls.Add(this.NombreContacto);
            this.Controls.Add(this.labelContacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox CUIT;
        private System.Windows.Forms.MaskedTextBox CodPostal;
        private System.Windows.Forms.MaskedTextBox Telefono;
        private System.Windows.Forms.Label labelNCalle;
        private System.Windows.Forms.TextBox NCalle;
        private System.Windows.Forms.Label labelFCreacion;
        private System.Windows.Forms.TextBox Ciudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.MaskedTextBox FecCre;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.TextBox Dpto;
        private System.Windows.Forms.Label labelDpto;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox NroPiso;
        private System.Windows.Forms.Label labelNPiso;
        private System.Windows.Forms.TextBox Calle;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox RazonSocial;
        private System.Windows.Forms.Label labelRZ;
        private System.Windows.Forms.TextBox NombreContacto;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Button button2;

    }
}