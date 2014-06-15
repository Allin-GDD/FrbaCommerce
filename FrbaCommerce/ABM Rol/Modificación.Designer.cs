namespace FrbaCommerce.ABM_Rol
{
    partial class Modificación
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtQuitar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.lblHabil = new System.Windows.Forms.Label();
            this.cmbHabilitado = new System.Windows.Forms.ComboBox();
            this.chkQuitar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAgregar = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(474, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(439, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(94, 292);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(133, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 274);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos de rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.txtQuitar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtAgregar);
            this.groupBox2.Controls.Add(this.lblHabil);
            this.groupBox2.Controls.Add(this.cmbHabilitado);
            this.groupBox2.Controls.Add(this.chkQuitar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkAgregar);
            this.groupBox2.Location = new System.Drawing.Point(15, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 178);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionabilidad";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(461, 94);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(108, 23);
            this.btnQuitar.TabIndex = 68;
            this.btnQuitar.Text = "Seleccionar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtQuitar
            // 
            this.txtQuitar.Location = new System.Drawing.Point(146, 96);
            this.txtQuitar.Name = "txtQuitar";
            this.txtQuitar.ReadOnly = true;
            this.txtQuitar.Size = new System.Drawing.Size(290, 20);
            this.txtQuitar.TabIndex = 67;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(461, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 23);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Seleccionar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(146, 54);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.ReadOnly = true;
            this.txtAgregar.Size = new System.Drawing.Size(290, 20);
            this.txtAgregar.TabIndex = 65;
            // 
            // lblHabil
            // 
            this.lblHabil.AutoSize = true;
            this.lblHabil.Location = new System.Drawing.Point(16, 147);
            this.lblHabil.Name = "lblHabil";
            this.lblHabil.Size = new System.Drawing.Size(54, 13);
            this.lblHabil.TabIndex = 63;
            this.lblHabil.Text = "Habilitado";
            // 
            // cmbHabilitado
            // 
            this.cmbHabilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabilitado.FormattingEnabled = true;
            this.cmbHabilitado.Location = new System.Drawing.Point(136, 144);
            this.cmbHabilitado.Name = "cmbHabilitado";
            this.cmbHabilitado.Size = new System.Drawing.Size(62, 21);
            this.cmbHabilitado.TabIndex = 64;
            // 
            // chkQuitar
            // 
            this.chkQuitar.AutoSize = true;
            this.chkQuitar.Location = new System.Drawing.Point(43, 98);
            this.chkQuitar.Name = "chkQuitar";
            this.chkQuitar.Size = new System.Drawing.Size(54, 17);
            this.chkQuitar.TabIndex = 18;
            this.chkQuitar.Text = "Quitar";
            this.chkQuitar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Marque la opción que desea ejecutar";
            // 
            // chkAgregar
            // 
            this.chkAgregar.AutoSize = true;
            this.chkAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkAgregar.Location = new System.Drawing.Point(43, 55);
            this.chkAgregar.Name = "chkAgregar";
            this.chkAgregar.Size = new System.Drawing.Size(69, 18);
            this.chkAgregar.TabIndex = 17;
            this.chkAgregar.Text = "Agregar";
            this.chkAgregar.UseVisualStyleBackColor = true;
            // 
            // Modificación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 329);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificación";
            this.Text = "Modificación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAgregar;
        private System.Windows.Forms.CheckBox chkQuitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbHabilitado;
        private System.Windows.Forms.Label lblHabil;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.TextBox txtQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAgregar;

    }
}