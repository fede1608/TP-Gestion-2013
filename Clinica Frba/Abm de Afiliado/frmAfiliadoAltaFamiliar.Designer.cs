namespace Clinica_Frba.Abm_de_Afiliado
{
    partial class frmAfiliadoAltaFamiliar
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
            this.btn_ABMAfiliado_AltaFamiliar_no = new System.Windows.Forms.Button();
            this.btn_ABMAfiliado_AltaFamiliar_si = new System.Windows.Forms.Button();
            this.lbl_ABMAfiliado_AltaFamiliar_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ABMAfiliado_AltaFamiliar_no
            // 
            this.btn_ABMAfiliado_AltaFamiliar_no.Location = new System.Drawing.Point(185, 83);
            this.btn_ABMAfiliado_AltaFamiliar_no.Name = "btn_ABMAfiliado_AltaFamiliar_no";
            this.btn_ABMAfiliado_AltaFamiliar_no.Size = new System.Drawing.Size(75, 23);
            this.btn_ABMAfiliado_AltaFamiliar_no.TabIndex = 0;
            this.btn_ABMAfiliado_AltaFamiliar_no.Text = "No";
            this.btn_ABMAfiliado_AltaFamiliar_no.UseVisualStyleBackColor = true;
            this.btn_ABMAfiliado_AltaFamiliar_no.Click += new System.EventHandler(this.btn_ABMAfiliado_AltaFamiliar_no_Click);
            // 
            // btn_ABMAfiliado_AltaFamiliar_si
            // 
            this.btn_ABMAfiliado_AltaFamiliar_si.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btn_ABMAfiliado_AltaFamiliar_si.Location = new System.Drawing.Point(76, 83);
            this.btn_ABMAfiliado_AltaFamiliar_si.Name = "btn_ABMAfiliado_AltaFamiliar_si";
            this.btn_ABMAfiliado_AltaFamiliar_si.Size = new System.Drawing.Size(75, 23);
            this.btn_ABMAfiliado_AltaFamiliar_si.TabIndex = 1;
            this.btn_ABMAfiliado_AltaFamiliar_si.Text = "Si";
            this.btn_ABMAfiliado_AltaFamiliar_si.UseVisualStyleBackColor = true;
            this.btn_ABMAfiliado_AltaFamiliar_si.Click += new System.EventHandler(this.btn_ABMAfiliado_AltaFamiliar_si_Click);
            // 
            // lbl_ABMAfiliado_AltaFamiliar_texto
            // 
            this.lbl_ABMAfiliado_AltaFamiliar_texto.AutoSize = true;
            this.lbl_ABMAfiliado_AltaFamiliar_texto.Location = new System.Drawing.Point(146, 37);
            this.lbl_ABMAfiliado_AltaFamiliar_texto.Name = "lbl_ABMAfiliado_AltaFamiliar_texto";
            this.lbl_ABMAfiliado_AltaFamiliar_texto.Size = new System.Drawing.Size(43, 13);
            this.lbl_ABMAfiliado_AltaFamiliar_texto.TabIndex = 2;
            this.lbl_ABMAfiliado_AltaFamiliar_texto.Text = "Texto 1";
            this.lbl_ABMAfiliado_AltaFamiliar_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAfiliadoAltaFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 118);
            this.Controls.Add(this.lbl_ABMAfiliado_AltaFamiliar_texto);
            this.Controls.Add(this.btn_ABMAfiliado_AltaFamiliar_si);
            this.Controls.Add(this.btn_ABMAfiliado_AltaFamiliar_no);
            this.Name = "frmAfiliadoAltaFamiliar";
            this.Text = "frmAfiliadoAltaFamiliar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ABMAfiliado_AltaFamiliar_no;
        private System.Windows.Forms.Button btn_ABMAfiliado_AltaFamiliar_si;
        private System.Windows.Forms.Label lbl_ABMAfiliado_AltaFamiliar_texto;
    }
}