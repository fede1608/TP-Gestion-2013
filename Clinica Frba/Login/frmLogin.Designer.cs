namespace Clinica_Frba.NewFolder10
{
    partial class frmLogin
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkbPass = new System.Windows.Forms.CheckBox();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.grbRol = new System.Windows.Forms.GroupBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnAceptarRol = new System.Windows.Forms.Button();
            this.btnCancelarRol = new System.Windows.Forms.Button();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.grbLogin.SuspendLayout();
            this.grbRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(95, 149);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(17, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 16);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(17, 62);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(91, 16);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(137, 22);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(116, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(137, 59);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(116, 20);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(176, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkbPass
            // 
            this.chkbPass.AutoSize = true;
            this.chkbPass.Location = new System.Drawing.Point(137, 85);
            this.chkbPass.Name = "chkbPass";
            this.chkbPass.Size = new System.Drawing.Size(116, 17);
            this.chkbPass.TabIndex = 7;
            this.chkbPass.Text = "Mostrar Contraseña";
            this.chkbPass.UseVisualStyleBackColor = true;
            this.chkbPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grbLogin
            // 
            this.grbLogin.Controls.Add(this.lblIntentos);
            this.grbLogin.Controls.Add(this.btnCancelar);
            this.grbLogin.Controls.Add(this.chkbPass);
            this.grbLogin.Controls.Add(this.btnAceptar);
            this.grbLogin.Controls.Add(this.txtPass);
            this.grbLogin.Controls.Add(this.txtUser);
            this.grbLogin.Controls.Add(this.lblPass);
            this.grbLogin.Controls.Add(this.txtIntentos);
            this.grbLogin.Controls.Add(this.lblUser);
            this.grbLogin.Location = new System.Drawing.Point(15, 12);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(265, 178);
            this.grbLogin.TabIndex = 8;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Login";
            // 
            // txtIntentos
            // 
            this.txtIntentos.BackColor = System.Drawing.Color.White;
            this.txtIntentos.Location = new System.Drawing.Point(165, 111);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.Size = new System.Drawing.Size(18, 20);
            this.txtIntentos.TabIndex = 9;
            // 
            // grbRol
            // 
            this.grbRol.Controls.Add(this.btnCancelarRol);
            this.grbRol.Controls.Add(this.btnAceptarRol);
            this.grbRol.Controls.Add(this.cboRol);
            this.grbRol.Controls.Add(this.lblRol);
            this.grbRol.Location = new System.Drawing.Point(292, 12);
            this.grbRol.Name = "grbRol";
            this.grbRol.Size = new System.Drawing.Size(265, 178);
            this.grbRol.TabIndex = 11;
            this.grbRol.TabStop = false;
            this.grbRol.Text = "Rol";
            this.grbRol.Visible = false;
            // 
            // cboRol
            // 
            this.cboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(53, 78);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(156, 24);
            this.cboRol.TabIndex = 1;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(23, 24);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(120, 16);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Logearse como:";
            // 
            // btnAceptarRol
            // 
            this.btnAceptarRol.Location = new System.Drawing.Point(53, 149);
            this.btnAceptarRol.Name = "btnAceptarRol";
            this.btnAceptarRol.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarRol.TabIndex = 12;
            this.btnAceptarRol.Text = "Aceptar";
            this.btnAceptarRol.UseVisualStyleBackColor = true;
            this.btnAceptarRol.Visible = false;
            this.btnAceptarRol.Click += new System.EventHandler(this.btnAceptarRol_Click);
            // 
            // btnCancelarRol
            // 
            this.btnCancelarRol.Location = new System.Drawing.Point(134, 149);
            this.btnCancelarRol.Name = "btnCancelarRol";
            this.btnCancelarRol.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarRol.TabIndex = 13;
            this.btnCancelarRol.Text = "Cancelar";
            this.btnCancelarRol.UseVisualStyleBackColor = true;
            this.btnCancelarRol.Visible = false;
            this.btnCancelarRol.Click += new System.EventHandler(this.btnCancelarRol_Click);
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.Location = new System.Drawing.Point(17, 112);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(140, 16);
            this.lblIntentos.TabIndex = 14;
            this.lblIntentos.Text = "Intentos Restantes:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 199);
            this.Controls.Add(this.grbLogin);
            this.Controls.Add(this.grbRol);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.grbRol.ResumeLayout(false);
            this.grbRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkbPass;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.TextBox txtIntentos;
        private System.Windows.Forms.GroupBox grbRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnAceptarRol;
        private System.Windows.Forms.Button btnCancelarRol;
        private System.Windows.Forms.Label lblIntentos;
    }
}