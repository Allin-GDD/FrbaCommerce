namespace FrbaCommerce.Utiles.Ventanas
{
    partial class CambiarPw
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwOriginal = new System.Windows.Forms.TextBox();
            this.txtNewPw1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPw2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ingrese una nueva contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(100, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(199, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPwOriginal
            // 
            this.txtPwOriginal.Location = new System.Drawing.Point(100, 64);
            this.txtPwOriginal.Name = "txtPwOriginal";
            this.txtPwOriginal.Size = new System.Drawing.Size(199, 20);
            this.txtPwOriginal.TabIndex = 2;
            this.txtPwOriginal.UseSystemPasswordChar = true;
            // 
            // txtNewPw1
            // 
            this.txtNewPw1.Location = new System.Drawing.Point(100, 117);
            this.txtNewPw1.Name = "txtNewPw1";
            this.txtNewPw1.Size = new System.Drawing.Size(199, 20);
            this.txtNewPw1.TabIndex = 3;
            this.txtNewPw1.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Vuelva a ingresar la contraseña";
            // 
            // txtNewPw2
            // 
            this.txtNewPw2.Location = new System.Drawing.Point(100, 170);
            this.txtNewPw2.Name = "txtNewPw2";
            this.txtNewPw2.Size = new System.Drawing.Size(199, 20);
            this.txtNewPw2.TabIndex = 4;
            this.txtNewPw2.UseSystemPasswordChar = true;
            // 
            // CambiarPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 255);
            this.Controls.Add(this.txtNewPw2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewPw1);
            this.Controls.Add(this.txtPwOriginal);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CambiarPw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwOriginal;
        private System.Windows.Forms.TextBox txtNewPw1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPw2;
    }
}