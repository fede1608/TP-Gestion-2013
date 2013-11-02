namespace Clinica_Frba.Pedir_Turno
{
    partial class frmSolicitarTurno
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo_especialidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_fecha = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboHorario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_profesional = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_afiliado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_afiliado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_aceptar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combo_profesional);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboHorario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_fecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_especialidad);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Selecciona una Especialidad:";
            // 
            // combo_especialidad
            // 
            this.combo_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_especialidad.FormattingEnabled = true;
            this.combo_especialidad.Location = new System.Drawing.Point(29, 92);
            this.combo_especialidad.Name = "combo_especialidad";
            this.combo_especialidad.Size = new System.Drawing.Size(145, 21);
            this.combo_especialidad.TabIndex = 0;
            this.combo_especialidad.SelectedIndexChanged += new System.EventHandler(this.combo_especialidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "3. Selecciona una Fecha:";
            // 
            // combo_fecha
            // 
            this.combo_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_fecha.Enabled = false;
            this.combo_fecha.FormattingEnabled = true;
            this.combo_fecha.Location = new System.Drawing.Point(29, 162);
            this.combo_fecha.Name = "combo_fecha";
            this.combo_fecha.Size = new System.Drawing.Size(145, 21);
            this.combo_fecha.TabIndex = 2;
            this.combo_fecha.SelectedIndexChanged += new System.EventHandler(this.combo_fecha_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "4. Selecciona un Horario:";
            // 
            // comboHorario
            // 
            this.comboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHorario.Enabled = false;
            this.comboHorario.FormattingEnabled = true;
            this.comboHorario.Location = new System.Drawing.Point(191, 162);
            this.comboHorario.Name = "comboHorario";
            this.comboHorario.Size = new System.Drawing.Size(145, 21);
            this.comboHorario.TabIndex = 4;
            this.comboHorario.SelectedIndexChanged += new System.EventHandler(this.comboHorario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "2. Selecciona un Profesional:";
            // 
            // combo_profesional
            // 
            this.combo_profesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_profesional.Enabled = false;
            this.combo_profesional.FormattingEnabled = true;
            this.combo_profesional.Location = new System.Drawing.Point(194, 92);
            this.combo_profesional.Name = "combo_profesional";
            this.combo_profesional.Size = new System.Drawing.Size(145, 21);
            this.combo_profesional.TabIndex = 6;
            this.combo_profesional.SelectedIndexChanged += new System.EventHandler(this.combo_profesional_SelectedIndexChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(261, 214);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(29, 214);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_afiliado
            // 
            this.lbl_afiliado.AutoSize = true;
            this.lbl_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afiliado.Location = new System.Drawing.Point(79, 25);
            this.lbl_afiliado.Name = "lbl_afiliado";
            this.lbl_afiliado.Size = new System.Drawing.Size(103, 13);
            this.lbl_afiliado.TabIndex = 11;
            this.lbl_afiliado.Text = "Apellido. Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Afiliado: ";
            // 
            // frmSolicitarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 276);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSolicitarTurno";
            this.Text = "Solicitar Turno";
            this.Load += new System.EventHandler(this.frmSolicitarTurno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_especialidad;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_profesional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_fecha;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_afiliado;
        private System.Windows.Forms.Label label5;
    }
}