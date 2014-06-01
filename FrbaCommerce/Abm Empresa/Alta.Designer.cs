namespace FrbaCommerce.Abm_Empresa
{
    partial class Alta
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.CodPostal = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelCP = new System.Windows.Forms.Label();
            this.Dpto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFCreacion = new System.Windows.Forms.Label();
            this.Ciudad = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.labelDpto = new System.Windows.Forms.Label();
            this.Localidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.NroPiso = new System.Windows.Forms.TextBox();
            this.labelNPiso = new System.Windows.Forms.Label();
            this.Calle = new System.Windows.Forms.TextBox();
            this.labelCalle = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.CUIT = new System.Windows.Forms.TextBox();
            this.RazonSocial = new System.Windows.Forms.TextBox();
            this.labelRZ = new System.Windows.Forms.Label();
            this.NombreContacto = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelNroCalle = new System.Windows.Forms.Label();
            this.NroCalle = new System.Windows.Forms.TextBox();
            this.labelCreacion = new System.Windows.Forms.Label();
            this.NCalle = new System.Windows.Forms.TextBox();
            this.labelNCalle = new System.Windows.Forms.Label();
            this.FecCre = new System.Windows.Forms.MaskedTextBox(); 
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(185, 372);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 12;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // txtFechaNac
            // 
            this.FecCre.Location = new System.Drawing.Point(114, 320);
            this.FecCre.Mask = "00/00/0000";
            this.FecCre.Name = "FecCre";
            this.FecCre.Size = new System.Drawing.Size(134, 20);
            this.FecCre.TabIndex = 29;
            this.FecCre.ValidatingType = typeof(System.DateTime);
            // CodPostal
            // 
            this.CodPostal.Location = new System.Drawing.Point(82, 265);
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.Size = new System.Drawing.Size(167, 20);
            this.CodPostal.TabIndex = 27;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(11, 372);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(12, 268);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(61, 13);
            this.labelCP.TabIndex = 26;
            this.labelCP.Text = "Cód. Postal";
            // 
            // Dpto
            // 
            this.Dpto.Location = new System.Drawing.Point(180, 214);
            this.Dpto.Name = "Dpto";
            this.Dpto.Size = new System.Drawing.Size(68, 20);
            this.Dpto.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNCalle);
            this.groupBox1.Controls.Add(this.NCalle);
            this.groupBox1.Controls.Add(this.labelFCreacion);
            this.groupBox1.Controls.Add(this.Ciudad);
            this.groupBox1.Controls.Add(this.labelCiudad);
            this.groupBox1.Controls.Add(this.labelCUIT);
            this.groupBox1.Controls.Add(this.FecCre);
            this.groupBox1.Controls.Add(this.CodPostal);
            this.groupBox1.Controls.Add(this.labelCP);
            this.groupBox1.Controls.Add(this.Dpto);
            this.groupBox1.Controls.Add(this.labelDpto);
            this.groupBox1.Controls.Add(this.Localidad);
            this.groupBox1.Controls.Add(this.labelLocalidad);
            this.groupBox1.Controls.Add(this.NroPiso);
            this.groupBox1.Controls.Add(this.labelNPiso);
            this.groupBox1.Controls.Add(this.Calle);
            this.groupBox1.Controls.Add(this.labelCalle);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.labelTel);
            this.groupBox1.Controls.Add(this.Mail);
            this.groupBox1.Controls.Add(this.labelMail);
            this.groupBox1.Controls.Add(this.CUIT);
            this.groupBox1.Controls.Add(this.RazonSocial);
            this.groupBox1.Controls.Add(this.labelRZ);
            this.groupBox1.Controls.Add(this.NombreContacto);
            this.groupBox1.Controls.Add(this.labelContacto);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 354);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos de rol";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelFCreacion
            // 
            this.labelFCreacion.AutoSize = true;
            this.labelFCreacion.Location = new System.Drawing.Point(14, 323);
            this.labelFCreacion.Name = "labelFCreacion";
            this.labelFCreacion.Size = new System.Drawing.Size(96, 13);
            this.labelFCreacion.TabIndex = 35;
            this.labelFCreacion.Text = "Fecha de creacion";
            // 
            // Ciudad
            // 
            this.Ciudad.Location = new System.Drawing.Point(63, 292);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(186, 20);
            this.Ciudad.TabIndex = 34;
            this.Ciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ciudad.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(12, 297);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 13);
            this.labelCiudad.TabIndex = 33;
            this.labelCiudad.Text = "Ciudad";
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Location = new System.Drawing.Point(12, 85);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(32, 13);
            this.labelCUIT.TabIndex = 32;
            this.labelCUIT.Text = "CUIT";
            // 
            // labelDpto
            // 
            this.labelDpto.AutoSize = true;
            this.labelDpto.Location = new System.Drawing.Point(144, 214);
            this.labelDpto.Name = "labelDpto";
            this.labelDpto.Size = new System.Drawing.Size(30, 13);
            this.labelDpto.TabIndex = 24;
            this.labelDpto.Text = "Dpto";
            // 
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(82, 240);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(167, 20);
            this.Localidad.TabIndex = 23;
            this.Localidad.TextChanged += new System.EventHandler(this.Localidad_TextChanged);
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(12, 243);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(53, 13);
            this.labelLocalidad.TabIndex = 22;
            this.labelLocalidad.Text = "Localidad";
            // 
            // NroPiso
            // 
            this.NroPiso.Location = new System.Drawing.Point(63, 213);
            this.NroPiso.Name = "NroPiso";
            this.NroPiso.Size = new System.Drawing.Size(55, 20);
            this.NroPiso.TabIndex = 21;
            // 
            // labelNPiso
            // 
            this.labelNPiso.AutoSize = true;
            this.labelNPiso.Location = new System.Drawing.Point(12, 217);
            this.labelNPiso.Name = "labelNPiso";
            this.labelNPiso.Size = new System.Drawing.Size(47, 13);
            this.labelNPiso.TabIndex = 20;
            this.labelNPiso.Text = "Nro Piso";
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(63, 165);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(186, 20);
            this.Calle.TabIndex = 19;
            this.Calle.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(12, 168);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(30, 13);
            this.labelCalle.TabIndex = 18;
            this.labelCalle.Text = "Calle";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(63, 137);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(186, 20);
            this.Telefono.TabIndex = 17;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(12, 140);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 13);
            this.labelTel.TabIndex = 16;
            this.labelTel.Text = "Teléfono";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(63, 111);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(186, 20);
            this.Mail.TabIndex = 15;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(12, 114);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 14;
            this.labelMail.Text = "Mail";
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(63, 82);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(185, 20);
            this.CUIT.TabIndex = 11;
            // 
            // RazonSocial
            // 
            this.RazonSocial.Location = new System.Drawing.Point(87, 54);
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Size = new System.Drawing.Size(162, 20);
            this.RazonSocial.TabIndex = 9;
            this.RazonSocial.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelRZ
            // 
            this.labelRZ.AutoSize = true;
            this.labelRZ.Location = new System.Drawing.Point(12, 57);
            this.labelRZ.Name = "labelRZ";
            this.labelRZ.Size = new System.Drawing.Size(70, 13);
            this.labelRZ.TabIndex = 8;
            this.labelRZ.Text = "Razón Social";
            // 
            // NombreContacto
            // 
            this.NombreContacto.Location = new System.Drawing.Point(122, 28);
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Size = new System.Drawing.Size(127, 20);
            this.NombreContacto.TabIndex = 7;
            this.NombreContacto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(12, 31);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(104, 13);
            this.labelContacto.TabIndex = 6;
            this.labelContacto.Text = "Nombre de contacto";
            // 
            // labelNroCalle
            // 
            this.labelNroCalle.Location = new System.Drawing.Point(0, 0);
            this.labelNroCalle.Name = "labelNroCalle";
            this.labelNroCalle.Size = new System.Drawing.Size(100, 23);
            this.labelNroCalle.TabIndex = 0;
            // 
            // NroCalle
            // 
            this.NroCalle.Location = new System.Drawing.Point(0, 0);
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.Size = new System.Drawing.Size(100, 20);
            this.NroCalle.TabIndex = 0;
            // 
            // labelCreacion
            // 
            this.labelCreacion.AutoSize = true;
            this.labelCreacion.Location = new System.Drawing.Point(12, 307);
            this.labelCreacion.Name = "labelCreacion";
            this.labelCreacion.Size = new System.Drawing.Size(96, 13);
            this.labelCreacion.TabIndex = 28;
            this.labelCreacion.Text = "Fecha de creación";
            // 
            // textBox1
            // 
            this.NCalle.Location = new System.Drawing.Point(147, 190);
            this.NCalle.Name = "NCalle";
            this.NCalle.Size = new System.Drawing.Size(100, 20);
            this.NCalle.TabIndex = 36;
            // 
            // label1
            // 
            this.labelNCalle.AutoSize = true;
            this.labelNCalle.Location = new System.Drawing.Point(14, 190);
            this.labelNCalle.Name = "labelNCalle";
            this.labelNCalle.Size = new System.Drawing.Size(44, 13);
            this.labelNCalle.TabIndex = 37;
            this.labelNCalle.Text = "Numero";
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 414);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alta";
            this.Text = "Alta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
    
        private System.Windows.Forms.TextBox CodPostal;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.TextBox Dpto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCreacion;
        private System.Windows.Forms.Label labelDpto;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox NroPiso;
        private System.Windows.Forms.Label labelNPiso;
        private System.Windows.Forms.TextBox Calle;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelNroCalle;
        private System.Windows.Forms.TextBox NroCalle;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox RazonSocial;
        private System.Windows.Forms.Label labelRZ;
        private System.Windows.Forms.TextBox NombreContacto;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.TextBox CUIT;
        private System.Windows.Forms.TextBox Ciudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelFCreacion;
        private System.Windows.Forms.Label labelNCalle;
        private System.Windows.Forms.TextBox NCalle;
        private System.Windows.Forms.MaskedTextBox FecCre;
    }
}