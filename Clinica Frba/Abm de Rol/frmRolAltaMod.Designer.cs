namespace Clinica_Frba.Abm_de_Rol
{
    partial class frmRolAltaMod
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_habilitado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptar_alta = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar_mod = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_habilitado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // chk_habilitado
            // 
            this.chk_habilitado.AutoSize = true;
            this.chk_habilitado.Checked = true;
            this.chk_habilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_habilitado.Location = new System.Drawing.Point(142, 74);
            this.chk_habilitado.Name = "chk_habilitado";
            this.chk_habilitado.Size = new System.Drawing.Size(73, 17);
            this.chk_habilitado.TabIndex = 5;
            this.chk_habilitado.Text = "Habilitado";
            this.chk_habilitado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Permisos:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(23, 128);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(239, 169);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btn_aceptar_alta
            // 
            this.btn_aceptar_alta.Location = new System.Drawing.Point(208, 345);
            this.btn_aceptar_alta.Name = "btn_aceptar_alta";
            this.btn_aceptar_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_alta.TabIndex = 1;
            this.btn_aceptar_alta.Text = "Aceptar";
            this.btn_aceptar_alta.UseVisualStyleBackColor = true;
            this.btn_aceptar_alta.Click += new System.EventHandler(this.btn_aceptar_alta_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(44, 345);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar_mod
            // 
            this.btn_aceptar_mod.Location = new System.Drawing.Point(208, 344);
            this.btn_aceptar_mod.Name = "btn_aceptar_mod";
            this.btn_aceptar_mod.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_mod.TabIndex = 3;
            this.btn_aceptar_mod.Text = "Aceptar";
            this.btn_aceptar_mod.UseVisualStyleBackColor = true;
            this.btn_aceptar_mod.Click += new System.EventHandler(this.btn_aceptar_mod_Click);
            // 
            // frmRolAltaMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 380);
            this.Controls.Add(this.btn_aceptar_mod);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar_alta);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRolAltaMod";
            this.Text = "Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox chk_habilitado;
        private System.Windows.Forms.Button btn_aceptar_alta;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar_mod;
    }
}