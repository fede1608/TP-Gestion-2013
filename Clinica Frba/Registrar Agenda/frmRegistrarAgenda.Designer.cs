namespace Clinica_Frba.Registrar_Agenda
{
    partial class frmRegistrarAgenda
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.combo_sabado_fin = new System.Windows.Forms.ComboBox();
            this.combo_viernes_fin = new System.Windows.Forms.ComboBox();
            this.combo_jueves_fin = new System.Windows.Forms.ComboBox();
            this.combo_miercoles_fin = new System.Windows.Forms.ComboBox();
            this.combo_martes_fin = new System.Windows.Forms.ComboBox();
            this.combo_lunes_fin = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_sabado_inicio = new System.Windows.Forms.ComboBox();
            this.combo_viernes_inicio = new System.Windows.Forms.ComboBox();
            this.combo_jueves_inicio = new System.Windows.Forms.ComboBox();
            this.combo_miercoles_inicio = new System.Windows.Forms.ComboBox();
            this.combo_martes_inicio = new System.Windows.Forms.ComboBox();
            this.combo_lunes_inicio = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_sabado = new System.Windows.Forms.CheckBox();
            this.chk_viernes = new System.Windows.Forms.CheckBox();
            this.chk_jueves = new System.Windows.Forms.CheckBox();
            this.chk_miercoles = new System.Windows.Forms.CheckBox();
            this.chk_martes = new System.Windows.Forms.CheckBox();
            this.chk_lunes = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_profesional = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_especialidad = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agenda";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dtp_fin);
            this.groupBox5.Controls.Add(this.dtp_inicio);
            this.groupBox5.Location = new System.Drawing.Point(13, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(431, 85);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Establecer Período";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Seleccionar Fecha de Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Seleccionar Fecha de Inicio:";
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(221, 53);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(200, 20);
            this.dtp_fin.TabIndex = 1;
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Location = new System.Drawing.Point(10, 53);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_inicio.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.combo_sabado_fin);
            this.groupBox4.Controls.Add(this.combo_viernes_fin);
            this.groupBox4.Controls.Add(this.combo_jueves_fin);
            this.groupBox4.Controls.Add(this.combo_miercoles_fin);
            this.groupBox4.Controls.Add(this.combo_martes_fin);
            this.groupBox4.Controls.Add(this.combo_lunes_fin);
            this.groupBox4.Location = new System.Drawing.Point(13, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(599, 57);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccionar Horario de Fin";
            // 
            // combo_sabado_fin
            // 
            this.combo_sabado_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sabado_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_sabado_fin.FormattingEnabled = true;
            this.combo_sabado_fin.Location = new System.Drawing.Point(510, 19);
            this.combo_sabado_fin.Name = "combo_sabado_fin";
            this.combo_sabado_fin.Size = new System.Drawing.Size(67, 21);
            this.combo_sabado_fin.TabIndex = 23;
            this.combo_sabado_fin.SelectedIndexChanged += new System.EventHandler(this.combo_sabado_fin_SelectedIndexChanged);
            // 
            // combo_viernes_fin
            // 
            this.combo_viernes_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_viernes_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_viernes_fin.FormattingEnabled = true;
            this.combo_viernes_fin.Items.AddRange(new object[] {
            ""});
            this.combo_viernes_fin.Location = new System.Drawing.Point(414, 19);
            this.combo_viernes_fin.Name = "combo_viernes_fin";
            this.combo_viernes_fin.Size = new System.Drawing.Size(67, 21);
            this.combo_viernes_fin.TabIndex = 22;
            // 
            // combo_jueves_fin
            // 
            this.combo_jueves_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_jueves_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_jueves_fin.FormattingEnabled = true;
            this.combo_jueves_fin.Location = new System.Drawing.Point(317, 19);
            this.combo_jueves_fin.Name = "combo_jueves_fin";
            this.combo_jueves_fin.Size = new System.Drawing.Size(67, 21);
            this.combo_jueves_fin.TabIndex = 21;
            // 
            // combo_miercoles_fin
            // 
            this.combo_miercoles_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_miercoles_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_miercoles_fin.FormattingEnabled = true;
            this.combo_miercoles_fin.Location = new System.Drawing.Point(218, 19);
            this.combo_miercoles_fin.Name = "combo_miercoles_fin";
            this.combo_miercoles_fin.Size = new System.Drawing.Size(67, 21);
            this.combo_miercoles_fin.TabIndex = 20;
            // 
            // combo_martes_fin
            // 
            this.combo_martes_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_martes_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_martes_fin.FormattingEnabled = true;
            this.combo_martes_fin.Location = new System.Drawing.Point(113, 21);
            this.combo_martes_fin.Name = "combo_martes_fin";
            this.combo_martes_fin.Size = new System.Drawing.Size(67, 21);
            this.combo_martes_fin.TabIndex = 19;
            // 
            // combo_lunes_fin
            // 
            this.combo_lunes_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_lunes_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_lunes_fin.FormattingEnabled = true;
            this.combo_lunes_fin.Location = new System.Drawing.Point(10, 21);
            this.combo_lunes_fin.Name = "combo_lunes_fin";
            this.combo_lunes_fin.Size = new System.Drawing.Size(67, 21);
            this.combo_lunes_fin.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_sabado_inicio);
            this.groupBox3.Controls.Add(this.combo_viernes_inicio);
            this.groupBox3.Controls.Add(this.combo_jueves_inicio);
            this.groupBox3.Controls.Add(this.combo_miercoles_inicio);
            this.groupBox3.Controls.Add(this.combo_martes_inicio);
            this.groupBox3.Controls.Add(this.combo_lunes_inicio);
            this.groupBox3.Location = new System.Drawing.Point(13, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 58);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Horarios de Inicio";
            // 
            // combo_sabado_inicio
            // 
            this.combo_sabado_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sabado_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_sabado_inicio.FormattingEnabled = true;
            this.combo_sabado_inicio.Location = new System.Drawing.Point(510, 23);
            this.combo_sabado_inicio.Name = "combo_sabado_inicio";
            this.combo_sabado_inicio.Size = new System.Drawing.Size(67, 21);
            this.combo_sabado_inicio.TabIndex = 13;
            this.combo_sabado_inicio.SelectedIndexChanged += new System.EventHandler(this.combo_sabado_inicio_SelectedIndexChanged);
            // 
            // combo_viernes_inicio
            // 
            this.combo_viernes_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_viernes_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_viernes_inicio.FormattingEnabled = true;
            this.combo_viernes_inicio.Location = new System.Drawing.Point(414, 23);
            this.combo_viernes_inicio.Name = "combo_viernes_inicio";
            this.combo_viernes_inicio.Size = new System.Drawing.Size(67, 21);
            this.combo_viernes_inicio.TabIndex = 12;
            this.combo_viernes_inicio.SelectedIndexChanged += new System.EventHandler(this.combo_viernes_inicio_SelectedIndexChanged);
            // 
            // combo_jueves_inicio
            // 
            this.combo_jueves_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_jueves_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_jueves_inicio.FormattingEnabled = true;
            this.combo_jueves_inicio.Location = new System.Drawing.Point(317, 23);
            this.combo_jueves_inicio.Name = "combo_jueves_inicio";
            this.combo_jueves_inicio.Size = new System.Drawing.Size(67, 21);
            this.combo_jueves_inicio.TabIndex = 11;
            this.combo_jueves_inicio.SelectedIndexChanged += new System.EventHandler(this.combo_jueves_inicio_SelectedIndexChanged);
            // 
            // combo_miercoles_inicio
            // 
            this.combo_miercoles_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_miercoles_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_miercoles_inicio.FormattingEnabled = true;
            this.combo_miercoles_inicio.Location = new System.Drawing.Point(218, 23);
            this.combo_miercoles_inicio.Name = "combo_miercoles_inicio";
            this.combo_miercoles_inicio.Size = new System.Drawing.Size(67, 21);
            this.combo_miercoles_inicio.TabIndex = 10;
            this.combo_miercoles_inicio.SelectedIndexChanged += new System.EventHandler(this.combo_miercoles_inicio_SelectedIndexChanged);
            // 
            // combo_martes_inicio
            // 
            this.combo_martes_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_martes_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_martes_inicio.FormattingEnabled = true;
            this.combo_martes_inicio.Location = new System.Drawing.Point(113, 23);
            this.combo_martes_inicio.Name = "combo_martes_inicio";
            this.combo_martes_inicio.Size = new System.Drawing.Size(67, 21);
            this.combo_martes_inicio.TabIndex = 9;
            this.combo_martes_inicio.SelectedIndexChanged += new System.EventHandler(this.combo_martes_inicio_SelectedIndexChanged);
            // 
            // combo_lunes_inicio
            // 
            this.combo_lunes_inicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.combo_lunes_inicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_lunes_inicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_lunes_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_lunes_inicio.FormattingEnabled = true;
            this.combo_lunes_inicio.Location = new System.Drawing.Point(12, 23);
            this.combo_lunes_inicio.Name = "combo_lunes_inicio";
            this.combo_lunes_inicio.Size = new System.Drawing.Size(67, 21);
            this.combo_lunes_inicio.TabIndex = 8;
            this.combo_lunes_inicio.SelectedIndexChanged += new System.EventHandler(this.combo_lunes_inicio_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_sabado);
            this.groupBox2.Controls.Add(this.chk_viernes);
            this.groupBox2.Controls.Add(this.chk_jueves);
            this.groupBox2.Controls.Add(this.chk_miercoles);
            this.groupBox2.Controls.Add(this.chk_martes);
            this.groupBox2.Controls.Add(this.chk_lunes);
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 43);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Días";
            // 
            // chk_sabado
            // 
            this.chk_sabado.AutoSize = true;
            this.chk_sabado.Location = new System.Drawing.Point(510, 19);
            this.chk_sabado.Name = "chk_sabado";
            this.chk_sabado.Size = new System.Drawing.Size(63, 17);
            this.chk_sabado.TabIndex = 7;
            this.chk_sabado.Text = "Sábado";
            this.chk_sabado.UseVisualStyleBackColor = true;
            this.chk_sabado.CheckedChanged += new System.EventHandler(this.chk_sabado_CheckedChanged);
            // 
            // chk_viernes
            // 
            this.chk_viernes.AutoSize = true;
            this.chk_viernes.Location = new System.Drawing.Point(414, 19);
            this.chk_viernes.Name = "chk_viernes";
            this.chk_viernes.Size = new System.Drawing.Size(61, 17);
            this.chk_viernes.TabIndex = 6;
            this.chk_viernes.Text = "Viernes";
            this.chk_viernes.UseVisualStyleBackColor = true;
            // 
            // chk_jueves
            // 
            this.chk_jueves.AutoSize = true;
            this.chk_jueves.Location = new System.Drawing.Point(317, 19);
            this.chk_jueves.Name = "chk_jueves";
            this.chk_jueves.Size = new System.Drawing.Size(60, 17);
            this.chk_jueves.TabIndex = 5;
            this.chk_jueves.Text = "Jueves";
            this.chk_jueves.UseVisualStyleBackColor = true;
            // 
            // chk_miercoles
            // 
            this.chk_miercoles.AutoSize = true;
            this.chk_miercoles.Location = new System.Drawing.Point(214, 19);
            this.chk_miercoles.Name = "chk_miercoles";
            this.chk_miercoles.Size = new System.Drawing.Size(71, 17);
            this.chk_miercoles.TabIndex = 4;
            this.chk_miercoles.Text = "Miércoles";
            this.chk_miercoles.UseVisualStyleBackColor = true;
            // 
            // chk_martes
            // 
            this.chk_martes.AutoSize = true;
            this.chk_martes.Location = new System.Drawing.Point(113, 19);
            this.chk_martes.Name = "chk_martes";
            this.chk_martes.Size = new System.Drawing.Size(58, 17);
            this.chk_martes.TabIndex = 3;
            this.chk_martes.Text = "Martes";
            this.chk_martes.UseVisualStyleBackColor = true;
            // 
            // chk_lunes
            // 
            this.chk_lunes.AutoSize = true;
            this.chk_lunes.Location = new System.Drawing.Point(12, 17);
            this.chk_lunes.Name = "chk_lunes";
            this.chk_lunes.Size = new System.Drawing.Size(55, 17);
            this.chk_lunes.TabIndex = 2;
            this.chk_lunes.Text = "Lunes";
            this.chk_lunes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Agregar Agenda al Profesional:";
            // 
            // lbl_profesional
            // 
            this.lbl_profesional.AutoSize = true;
            this.lbl_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesional.Location = new System.Drawing.Point(182, 16);
            this.lbl_profesional.Name = "lbl_profesional";
            this.lbl_profesional.Size = new System.Drawing.Size(47, 15);
            this.lbl_profesional.TabIndex = 2;
            this.lbl_profesional.Text = "label4";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(564, 18);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(381, 19);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.combo_especialidad);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(452, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(160, 84);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Seleccionar Especialidad:";
            // 
            // combo_especialidad
            // 
            this.combo_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_especialidad.FormattingEnabled = true;
            this.combo_especialidad.Location = new System.Drawing.Point(8, 51);
            this.combo_especialidad.Name = "combo_especialidad";
            this.combo_especialidad.Size = new System.Drawing.Size(142, 21);
            this.combo_especialidad.TabIndex = 30;
            // 
            // frmRegistrarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 372);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_profesional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarAgenda";
            this.Text = "Registrar Agenda";
            this.Load += new System.EventHandler(this.frmRegistrarAgenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.CheckBox chk_sabado;
        private System.Windows.Forms.CheckBox chk_viernes;
        private System.Windows.Forms.CheckBox chk_jueves;
        private System.Windows.Forms.CheckBox chk_miercoles;
        private System.Windows.Forms.CheckBox chk_martes;
        private System.Windows.Forms.CheckBox chk_lunes;
        private System.Windows.Forms.ComboBox combo_lunes_inicio;
        private System.Windows.Forms.ComboBox combo_sabado_inicio;
        private System.Windows.Forms.ComboBox combo_viernes_inicio;
        private System.Windows.Forms.ComboBox combo_jueves_inicio;
        private System.Windows.Forms.ComboBox combo_miercoles_inicio;
        private System.Windows.Forms.ComboBox combo_martes_inicio;
        private System.Windows.Forms.ComboBox combo_lunes_fin;
        private System.Windows.Forms.ComboBox combo_sabado_fin;
        private System.Windows.Forms.ComboBox combo_viernes_fin;
        private System.Windows.Forms.ComboBox combo_jueves_fin;
        private System.Windows.Forms.ComboBox combo_miercoles_fin;
        private System.Windows.Forms.ComboBox combo_martes_fin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_profesional;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox combo_especialidad;
        private System.Windows.Forms.Label label4;
    }
}