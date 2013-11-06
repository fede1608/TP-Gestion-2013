namespace Clinica_Frba.Registro_Resultado_Atencion
{
    partial class frmRegistroAtencion
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_receta = new System.Windows.Forms.Button();
            this.lbl_consulta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_diagnostico = new System.Windows.Forms.TextBox();
            this.txt_sintomas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_hora_atencion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_profesional = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_turno = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_afiliado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(276, 223);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_receta);
            this.groupBox1.Controls.Add(this.lbl_consulta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_diagnostico);
            this.groupBox1.Controls.Add(this.txt_sintomas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_hora_atencion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_profesional);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_turno);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_aceptar);
            this.groupBox1.Controls.Add(this.lbl_afiliado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Consulta";
            // 
            // btn_receta
            // 
            this.btn_receta.Location = new System.Drawing.Point(22, 223);
            this.btn_receta.Name = "btn_receta";
            this.btn_receta.Size = new System.Drawing.Size(153, 23);
            this.btn_receta.TabIndex = 18;
            this.btn_receta.Text = "Crear Receta";
            this.btn_receta.UseVisualStyleBackColor = true;
            this.btn_receta.Click += new System.EventHandler(this.btn_receta_Click);
            // 
            // lbl_consulta
            // 
            this.lbl_consulta.AutoSize = true;
            this.lbl_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consulta.Location = new System.Drawing.Point(125, 25);
            this.lbl_consulta.Name = "lbl_consulta";
            this.lbl_consulta.Size = new System.Drawing.Size(41, 13);
            this.lbl_consulta.TabIndex = 17;
            this.lbl_consulta.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Numero de Consulta:";
            // 
            // txt_diagnostico
            // 
            this.txt_diagnostico.Location = new System.Drawing.Point(195, 132);
            this.txt_diagnostico.Multiline = true;
            this.txt_diagnostico.Name = "txt_diagnostico";
            this.txt_diagnostico.Size = new System.Drawing.Size(153, 79);
            this.txt_diagnostico.TabIndex = 15;
            // 
            // txt_sintomas
            // 
            this.txt_sintomas.Location = new System.Drawing.Point(22, 132);
            this.txt_sintomas.Multiline = true;
            this.txt_sintomas.Name = "txt_sintomas";
            this.txt_sintomas.Size = new System.Drawing.Size(153, 79);
            this.txt_sintomas.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Síntomas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diagnóstico:";
            // 
            // lbl_hora_atencion
            // 
            this.lbl_hora_atencion.AutoSize = true;
            this.lbl_hora_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_atencion.Location = new System.Drawing.Point(291, 75);
            this.lbl_hora_atencion.Name = "lbl_hora_atencion";
            this.lbl_hora_atencion.Size = new System.Drawing.Size(39, 13);
            this.lbl_hora_atencion.TabIndex = 11;
            this.lbl_hora_atencion.Text = "12:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hora de Atención:";
            // 
            // lbl_profesional
            // 
            this.lbl_profesional.AutoSize = true;
            this.lbl_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesional.Location = new System.Drawing.Point(260, 49);
            this.lbl_profesional.Name = "lbl_profesional";
            this.lbl_profesional.Size = new System.Drawing.Size(103, 13);
            this.lbl_profesional.TabIndex = 9;
            this.lbl_profesional.Text = "Apellido, Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Profesional:";
            // 
            // lbl_turno
            // 
            this.lbl_turno.AutoSize = true;
            this.lbl_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno.Location = new System.Drawing.Point(118, 75);
            this.lbl_turno.Name = "lbl_turno";
            this.lbl_turno.Size = new System.Drawing.Size(41, 13);
            this.lbl_turno.TabIndex = 7;
            this.lbl_turno.Text = "label3";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(195, 223);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de Turno:";
            // 
            // lbl_afiliado
            // 
            this.lbl_afiliado.AutoSize = true;
            this.lbl_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afiliado.Location = new System.Drawing.Point(72, 49);
            this.lbl_afiliado.Name = "lbl_afiliado";
            this.lbl_afiliado.Size = new System.Drawing.Size(103, 13);
            this.lbl_afiliado.TabIndex = 5;
            this.lbl_afiliado.Text = "Apellido, Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Afiliado: ";
            // 
            // frmRegistroAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistroAtencion";
            this.Text = "Registro Atención";
            this.Load += new System.EventHandler(this.frmRegistroAtencion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_profesional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_turno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_afiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diagnostico;
        private System.Windows.Forms.TextBox txt_sintomas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_hora_atencion;
        private System.Windows.Forms.Label lbl_consulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_receta;
    }
}