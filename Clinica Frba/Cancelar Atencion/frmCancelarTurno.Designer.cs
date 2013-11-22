namespace Clinica_Frba.Cancelar_Atencion
{
    partial class frmCancelarTurno
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
            this.lbl_afiliado = new System.Windows.Forms.Label();
            this.lbl_af = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.btn_profesional = new System.Windows.Forms.Button();
            this.btn_afiliado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_profesional = new System.Windows.Forms.Label();
            this.lbl_prf = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_cancelar_periodo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_afiliado
            // 
            this.lbl_afiliado.AutoSize = true;
            this.lbl_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afiliado.Location = new System.Drawing.Point(144, 55);
            this.lbl_afiliado.Name = "lbl_afiliado";
            this.lbl_afiliado.Size = new System.Drawing.Size(103, 13);
            this.lbl_afiliado.TabIndex = 13;
            this.lbl_afiliado.Text = "Apellido. Nombre";
            // 
            // lbl_af
            // 
            this.lbl_af.AutoSize = true;
            this.lbl_af.Location = new System.Drawing.Point(91, 55);
            this.lbl_af.Name = "lbl_af";
            this.lbl_af.Size = new System.Drawing.Size(47, 13);
            this.lbl_af.TabIndex = 12;
            this.lbl_af.Text = "Afiliado: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_admin);
            this.groupBox1.Controls.Add(this.btn_profesional);
            this.groupBox1.Controls.Add(this.btn_afiliado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_final);
            this.groupBox1.Controls.Add(this.dtp_inicial);
            this.groupBox1.Controls.Add(this.lbl_profesional);
            this.groupBox1.Controls.Add(this.lbl_prf);
            this.groupBox1.Controls.Add(this.btn_volver);
            this.groupBox1.Controls.Add(this.btn_cancelar_periodo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_afiliado);
            this.groupBox1.Controls.Add(this.lbl_af);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 258);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cancelar Turno";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.Location = new System.Drawing.Point(109, 16);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(83, 13);
            this.lbl_admin.TabIndex = 25;
            this.lbl_admin.Text = "Administrador";
            // 
            // btn_profesional
            // 
            this.btn_profesional.Location = new System.Drawing.Point(201, 88);
            this.btn_profesional.Name = "btn_profesional";
            this.btn_profesional.Size = new System.Drawing.Size(75, 23);
            this.btn_profesional.TabIndex = 24;
            this.btn_profesional.Text = "Profesional";
            this.btn_profesional.UseVisualStyleBackColor = true;
            this.btn_profesional.Click += new System.EventHandler(this.btn_profesional_Click);
            // 
            // btn_afiliado
            // 
            this.btn_afiliado.Location = new System.Drawing.Point(22, 88);
            this.btn_afiliado.Name = "btn_afiliado";
            this.btn_afiliado.Size = new System.Drawing.Size(75, 23);
            this.btn_afiliado.TabIndex = 23;
            this.btn_afiliado.Text = "Afiliado";
            this.btn_afiliado.UseVisualStyleBackColor = true;
            this.btn_afiliado.Click += new System.EventHandler(this.btn_afiliado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha Inicial:";
            // 
            // dtp_final
            // 
            this.dtp_final.Location = new System.Drawing.Point(94, 161);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(200, 20);
            this.dtp_final.TabIndex = 20;
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.Location = new System.Drawing.Point(94, 135);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(200, 20);
            this.dtp_inicial.TabIndex = 19;
            // 
            // lbl_profesional
            // 
            this.lbl_profesional.AutoSize = true;
            this.lbl_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesional.Location = new System.Drawing.Point(144, 42);
            this.lbl_profesional.Name = "lbl_profesional";
            this.lbl_profesional.Size = new System.Drawing.Size(103, 13);
            this.lbl_profesional.TabIndex = 18;
            this.lbl_profesional.Text = "Apellido. Nombre";
            // 
            // lbl_prf
            // 
            this.lbl_prf.AutoSize = true;
            this.lbl_prf.Location = new System.Drawing.Point(73, 42);
            this.lbl_prf.Name = "lbl_prf";
            this.lbl_prf.Size = new System.Drawing.Size(62, 13);
            this.lbl_prf.TabIndex = 17;
            this.lbl_prf.Text = "Profesional:";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(6, 229);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(111, 23);
            this.btn_volver.TabIndex = 16;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_cancelar_periodo
            // 
            this.btn_cancelar_periodo.Location = new System.Drawing.Point(94, 194);
            this.btn_cancelar_periodo.Name = "btn_cancelar_periodo";
            this.btn_cancelar_periodo.Size = new System.Drawing.Size(111, 23);
            this.btn_cancelar_periodo.TabIndex = 15;
            this.btn_cancelar_periodo.Text = "Cancelar Período";
            this.btn_cancelar_periodo.UseVisualStyleBackColor = true;
            this.btn_cancelar_periodo.Click += new System.EventHandler(this.btn_cancelar_periodo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar Turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCancelarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 281);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCancelarTurno";
            this.Text = "Cancelar Turno";
            this.Load += new System.EventHandler(this.frmCancelarTurno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_afiliado;
        private System.Windows.Forms.Label lbl_af;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_cancelar_periodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_profesional;
        private System.Windows.Forms.Label lbl_prf;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_profesional;
        private System.Windows.Forms.Button btn_afiliado;
        private System.Windows.Forms.Label lbl_admin;
    }
}