namespace FrbaCommerce.Abm_Cliente
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.lblDpto = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtNroPiso = new System.Windows.Forms.TextBox();
            this.lblNroPiso = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Está seguro que desea eliminar al cliente?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Enabled = false;
            this.txtFechaNac.Location = new System.Drawing.Point(143, 322);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(124, 20);
            this.txtFechaNac.TabIndex = 57;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.Enabled = false;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(137, 114);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(130, 21);
            this.cboTipoDoc.TabIndex = 39;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Enabled = false;
            this.txtNroCalle.Location = new System.Drawing.Point(105, 217);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(162, 20);
            this.txtNroCalle.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nro Calle";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(30, 324);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNac.TabIndex = 56;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Enabled = false;
            this.txtCodPostal.Location = new System.Drawing.Point(105, 295);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(162, 20);
            this.txtCodPostal.TabIndex = 55;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(30, 298);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(61, 13);
            this.lblCodPostal.TabIndex = 54;
            this.lblCodPostal.Text = "Cód. Postal";
            // 
            // txtDpto
            // 
            this.txtDpto.Enabled = false;
            this.txtDpto.Location = new System.Drawing.Point(212, 243);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(55, 20);
            this.txtDpto.TabIndex = 51;
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.Location = new System.Drawing.Point(176, 246);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(30, 13);
            this.lblDpto.TabIndex = 50;
            this.lblDpto.Text = "Dpto";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Location = new System.Drawing.Point(105, 269);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(162, 20);
            this.txtLocalidad.TabIndex = 53;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(30, 272);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 52;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtNroPiso
            // 
            this.txtNroPiso.Enabled = false;
            this.txtNroPiso.Location = new System.Drawing.Point(106, 243);
            this.txtNroPiso.Name = "txtNroPiso";
            this.txtNroPiso.Size = new System.Drawing.Size(55, 20);
            this.txtNroPiso.TabIndex = 49;
            // 
            // lblNroPiso
            // 
            this.lblNroPiso.AutoSize = true;
            this.lblNroPiso.Location = new System.Drawing.Point(30, 246);
            this.lblNroPiso.Name = "lblNroPiso";
            this.lblNroPiso.Size = new System.Drawing.Size(27, 13);
            this.lblNroPiso.TabIndex = 48;
            this.lblNroPiso.Text = "Piso";
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(105, 193);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(162, 20);
            this.txtCalle.TabIndex = 45;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(30, 196);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(49, 13);
            this.lblCalle.TabIndex = 44;
            this.lblCalle.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(105, 167);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(162, 20);
            this.txtTelefono.TabIndex = 43;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(30, 170);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 42;
            this.lblTel.Text = "Teléfono";
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(105, 141);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(162, 20);
            this.txtMail.TabIndex = 41;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(30, 144);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 40;
            this.lblMail.Text = "Mail";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(31, 118);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(99, 13);
            this.lblTipoDoc.TabIndex = 38;
            this.lblTipoDoc.Text = "Tipo de documento";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(105, 89);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(162, 20);
            this.txtDNI.TabIndex = 37;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(30, 92);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 36;
            this.lblDNI.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(105, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(162, 20);
            this.txtApellido.TabIndex = 35;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(31, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 34;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(195, -20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(120, -17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Enabled = false;
            this.txtNombre2.Location = new System.Drawing.Point(105, 35);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(162, 20);
            this.txtNombre2.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nombre";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 395);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.txtDpto);
            this.Controls.Add(this.lblDpto);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtNroPiso);
            this.Controls.Add(this.lblNroPiso);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Baja";
            this.Text = "Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtNroPiso;
        private System.Windows.Forms.Label lblNroPiso;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label label3;
    }
}