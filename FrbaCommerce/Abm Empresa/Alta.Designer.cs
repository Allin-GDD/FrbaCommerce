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
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelCP = new System.Windows.Forms.Label();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodPostal = new System.Windows.Forms.TextBox();
            this.CUIT = new System.Windows.Forms.MaskedTextBox();
            this.Telefono = new System.Windows.Forms.MaskedTextBox();
            this.labelNCalle = new System.Windows.Forms.Label();
            this.NCalle = new System.Windows.Forms.TextBox();
            this.labelFCreacion = new System.Windows.Forms.Label();
            this.Ciudad = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.FecCre = new System.Windows.Forms.MaskedTextBox();
            this.labelDpto = new System.Windows.Forms.Label();
            this.Localidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.txtNroPiso = new System.Windows.Forms.TextBox();
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
            this.labelNroCalle = new System.Windows.Forms.Label();
            this.NroCalle = new System.Windows.Forms.TextBox();
            this.labelCreacion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(179, 372);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(11, 372);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(6, 272);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(61, 13);
            this.labelCP.TabIndex = 26;
            this.labelCP.Text = "Cód. Postal";
            // 
            // txtDpto
            // 
            this.txtDpto.Location = new System.Drawing.Point(169, 216);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(74, 20);
            this.txtDpto.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodPostal);
            this.groupBox1.Controls.Add(this.CUIT);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.labelNCalle);
            this.groupBox1.Controls.Add(this.NCalle);
            this.groupBox1.Controls.Add(this.labelFCreacion);
            this.groupBox1.Controls.Add(this.Ciudad);
            this.groupBox1.Controls.Add(this.labelCiudad);
            this.groupBox1.Controls.Add(this.labelCUIT);
            this.groupBox1.Controls.Add(this.FecCre);
            this.groupBox1.Controls.Add(this.labelCP);
            this.groupBox1.Controls.Add(this.txtDpto);
            this.groupBox1.Controls.Add(this.labelDpto);
            this.groupBox1.Controls.Add(this.Localidad);
            this.groupBox1.Controls.Add(this.labelLocalidad);
            this.groupBox1.Controls.Add(this.txtNroPiso);
            this.groupBox1.Controls.Add(this.labelNPiso);
            this.groupBox1.Controls.Add(this.Calle);
            this.groupBox1.Controls.Add(this.labelCalle);
            this.groupBox1.Controls.Add(this.labelTel);
            this.groupBox1.Controls.Add(this.Mail);
            this.groupBox1.Controls.Add(this.labelMail);
            this.groupBox1.Controls.Add(this.RazonSocial);
            this.groupBox1.Controls.Add(this.labelRZ);
            this.groupBox1.Controls.Add(this.NombreContacto);
            this.groupBox1.Controls.Add(this.labelContacto);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 354);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos de rol";
            // 
            // CodPostal
            // 
            this.CodPostal.Location = new System.Drawing.Point(73, 268);
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.Size = new System.Drawing.Size(170, 20);
            this.CodPostal.TabIndex = 29;
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(57, 79);
            this.CUIT.Mask = "00-00000000-00";
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(186, 20);
            this.CUIT.TabIndex = 3;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(57, 137);
            this.Telefono.Mask = "000-0000-0000";
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(186, 20);
            this.Telefono.TabIndex = 5;
            // 
            // labelNCalle
            // 
            this.labelNCalle.AutoSize = true;
            this.labelNCalle.Location = new System.Drawing.Point(6, 193);
            this.labelNCalle.Name = "labelNCalle";
            this.labelNCalle.Size = new System.Drawing.Size(50, 13);
            this.labelNCalle.TabIndex = 22;
            this.labelNCalle.Text = "Nro Calle";
            // 
            // NCalle
            // 
            this.NCalle.Location = new System.Drawing.Point(62, 191);
            this.NCalle.Name = "NCalle";
            this.NCalle.Size = new System.Drawing.Size(182, 20);
            this.NCalle.TabIndex = 7;
            // 
            // labelFCreacion
            // 
            this.labelFCreacion.AutoSize = true;
            this.labelFCreacion.Location = new System.Drawing.Point(6, 323);
            this.labelFCreacion.Name = "labelFCreacion";
            this.labelFCreacion.Size = new System.Drawing.Size(96, 13);
            this.labelFCreacion.TabIndex = 28;
            this.labelFCreacion.Text = "Fecha de creación";
            // 
            // Ciudad
            // 
            this.Ciudad.Location = new System.Drawing.Point(61, 296);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(182, 20);
            this.Ciudad.TabIndex = 12;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(6, 299);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 13);
            this.labelCiudad.TabIndex = 27;
            this.labelCiudad.Text = "Ciudad";
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Location = new System.Drawing.Point(6, 82);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(32, 13);
            this.labelCUIT.TabIndex = 18;
            this.labelCUIT.Text = "CUIT";
            // 
            // FecCre
            // 
            this.FecCre.Location = new System.Drawing.Point(114, 320);
            this.FecCre.Mask = "00/00/0000";
            this.FecCre.Name = "FecCre";
            this.FecCre.Size = new System.Drawing.Size(129, 20);
            this.FecCre.TabIndex = 13;
            this.FecCre.ValidatingType = typeof(System.DateTime);
            // 
            // labelDpto
            // 
            this.labelDpto.AutoSize = true;
            this.labelDpto.Location = new System.Drawing.Point(133, 220);
            this.labelDpto.Name = "labelDpto";
            this.labelDpto.Size = new System.Drawing.Size(30, 13);
            this.labelDpto.TabIndex = 24;
            this.labelDpto.Text = "Dpto";
            // 
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(61, 242);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(182, 20);
            this.Localidad.TabIndex = 10;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(6, 246);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(53, 13);
            this.labelLocalidad.TabIndex = 25;
            this.labelLocalidad.Text = "Localidad";
            // 
            // txtNroPiso
            // 
            this.txtNroPiso.Location = new System.Drawing.Point(61, 217);
            this.txtNroPiso.Name = "txtNroPiso";
            this.txtNroPiso.Size = new System.Drawing.Size(57, 20);
            this.txtNroPiso.TabIndex = 8;
            // 
            // labelNPiso
            // 
            this.labelNPiso.AutoSize = true;
            this.labelNPiso.Location = new System.Drawing.Point(6, 220);
            this.labelNPiso.Name = "labelNPiso";
            this.labelNPiso.Size = new System.Drawing.Size(47, 13);
            this.labelNPiso.TabIndex = 23;
            this.labelNPiso.Text = "Nro Piso";
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(61, 165);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(182, 20);
            this.Calle.TabIndex = 6;
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(6, 168);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(49, 13);
            this.labelCalle.TabIndex = 21;
            this.labelCalle.Text = "Domicilio";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(6, 140);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 13);
            this.labelTel.TabIndex = 20;
            this.labelTel.Text = "Teléfono";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(57, 108);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(186, 20);
            this.Mail.TabIndex = 4;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(6, 111);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 19;
            this.labelMail.Text = "Mail";
            // 
            // RazonSocial
            // 
            this.RazonSocial.Location = new System.Drawing.Point(81, 51);
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Size = new System.Drawing.Size(162, 20);
            this.RazonSocial.TabIndex = 2;
            // 
            // labelRZ
            // 
            this.labelRZ.AutoSize = true;
            this.labelRZ.Location = new System.Drawing.Point(6, 54);
            this.labelRZ.Name = "labelRZ";
            this.labelRZ.Size = new System.Drawing.Size(70, 13);
            this.labelRZ.TabIndex = 17;
            this.labelRZ.Text = "Razón Social";
            // 
            // NombreContacto
            // 
            this.NombreContacto.Location = new System.Drawing.Point(116, 25);
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Size = new System.Drawing.Size(127, 20);
            this.NombreContacto.TabIndex = 1;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(6, 28);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(104, 13);
            this.labelContacto.TabIndex = 16;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "listado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "SeleList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCreacion;
        private System.Windows.Forms.Label labelDpto;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox txtNroPiso;
        private System.Windows.Forms.Label labelNPiso;
        private System.Windows.Forms.TextBox Calle;
        private System.Windows.Forms.Label labelCalle;
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
        private System.Windows.Forms.TextBox Ciudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelFCreacion;
        private System.Windows.Forms.Label labelNCalle;
        private System.Windows.Forms.TextBox NCalle;
        private System.Windows.Forms.MaskedTextBox FecCre;
        private System.Windows.Forms.MaskedTextBox Telefono;
        private System.Windows.Forms.MaskedTextBox CUIT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CodPostal;
    }
}