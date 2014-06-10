namespace FrbaCommerce.Generar_Publicacion
{
    partial class Generar_Publi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmbTipoPub = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVisib = new System.Windows.Forms.ComboBox();
            this.cmbRub = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visibilidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio unitario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rubros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tipo de Publicación";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 355);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Permitir preguntas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(81, 240);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 85);
            this.textBox5.TabIndex = 18;
            // 
            // cmbTipoPub
            // 
            this.cmbTipoPub.FormattingEnabled = true;
            this.cmbTipoPub.Items.AddRange(new object[] {
            "Subasta",
            "Compra inmediata"});
            this.cmbTipoPub.Location = new System.Drawing.Point(117, 73);
            this.cmbTipoPub.Name = "cmbTipoPub";
            this.cmbTipoPub.Size = new System.Drawing.Size(139, 21);
            this.cmbTipoPub.TabIndex = 19;
            this.cmbTipoPub.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPub_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbVisib);
            this.groupBox1.Controls.Add(this.cmbRub);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.cmbTipoPub);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 425);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicación";
            // 
            // cmbVisib
            // 
            this.cmbVisib.FormattingEnabled = true;
            this.cmbVisib.Location = new System.Drawing.Point(79, 32);
            this.cmbVisib.Name = "cmbVisib";
            this.cmbVisib.Size = new System.Drawing.Size(177, 21);
            this.cmbVisib.TabIndex = 25;
            // 
            // cmbRub
            // 
            this.cmbRub.FormattingEnabled = true;
            this.cmbRub.Location = new System.Drawing.Point(79, 114);
            this.cmbRub.Name = "cmbRub";
            this.cmbRub.Size = new System.Drawing.Size(177, 21);
            this.cmbRub.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Generar_Publi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Generar_Publi";
            this.Text = "Generador de Publicaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cmbTipoPub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbRub;
        private System.Windows.Forms.ComboBox cmbVisib;
    }
}