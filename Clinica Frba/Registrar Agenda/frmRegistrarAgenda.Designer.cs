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
            this.combo_sabado_fin = new System.Windows.Forms.ComboBox();
            this.combo_viernes_fin = new System.Windows.Forms.ComboBox();
            this.combo_jueves_fin = new System.Windows.Forms.ComboBox();
            this.combo_miercoles_fin = new System.Windows.Forms.ComboBox();
            this.combo_martes_fin = new System.Windows.Forms.ComboBox();
            this.combo_lunes_fin = new System.Windows.Forms.ComboBox();
            this.combo_sabado_inicio = new System.Windows.Forms.ComboBox();
            this.combo_viernes_inicio = new System.Windows.Forms.ComboBox();
            this.combo_jueves_inicio = new System.Windows.Forms.ComboBox();
            this.combo_miercoles_inicio = new System.Windows.Forms.ComboBox();
            this.combo_martes_inicio = new System.Windows.Forms.ComboBox();
            this.combo_lunes_inicio = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agenda";
            // 
            // combo_sabado_fin
            // 
            this.combo_sabado_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_sabado_fin.FormattingEnabled = true;
            this.combo_sabado_fin.Items.AddRange(new object[] {
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30"});
            this.combo_sabado_fin.Location = new System.Drawing.Point(438, 21);
            this.combo_sabado_fin.Name = "combo_sabado_fin";
            this.combo_sabado_fin.Size = new System.Drawing.Size(55, 21);
            this.combo_sabado_fin.TabIndex = 23;
            this.combo_sabado_fin.Text = "14:30";
            this.combo_sabado_fin.SelectedIndexChanged += new System.EventHandler(this.combo_sabado_fin_SelectedIndexChanged);
            // 
            // combo_viernes_fin
            // 
            this.combo_viernes_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_viernes_fin.FormattingEnabled = true;
            this.combo_viernes_fin.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_viernes_fin.Location = new System.Drawing.Point(352, 21);
            this.combo_viernes_fin.Name = "combo_viernes_fin";
            this.combo_viernes_fin.Size = new System.Drawing.Size(55, 21);
            this.combo_viernes_fin.TabIndex = 22;
            this.combo_viernes_fin.Text = "19:30";
            this.combo_viernes_fin.SelectedIndexChanged += new System.EventHandler(this.combo_viernes_fin_SelectedIndexChanged);
            // 
            // combo_jueves_fin
            // 
            this.combo_jueves_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_jueves_fin.FormattingEnabled = true;
            this.combo_jueves_fin.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_jueves_fin.Location = new System.Drawing.Point(265, 21);
            this.combo_jueves_fin.Name = "combo_jueves_fin";
            this.combo_jueves_fin.Size = new System.Drawing.Size(55, 21);
            this.combo_jueves_fin.TabIndex = 21;
            this.combo_jueves_fin.Text = "19:30";
            this.combo_jueves_fin.SelectedIndexChanged += new System.EventHandler(this.combo_jueves_fin_SelectedIndexChanged);
            // 
            // combo_miercoles_fin
            // 
            this.combo_miercoles_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_miercoles_fin.FormattingEnabled = true;
            this.combo_miercoles_fin.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_miercoles_fin.Location = new System.Drawing.Point(176, 21);
            this.combo_miercoles_fin.Name = "combo_miercoles_fin";
            this.combo_miercoles_fin.Size = new System.Drawing.Size(55, 21);
            this.combo_miercoles_fin.TabIndex = 20;
            this.combo_miercoles_fin.Text = "19:30";
            this.combo_miercoles_fin.SelectedIndexChanged += new System.EventHandler(this.combo_miercoles_fin_SelectedIndexChanged);
            // 
            // combo_martes_fin
            // 
            this.combo_martes_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_martes_fin.FormattingEnabled = true;
            this.combo_martes_fin.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_martes_fin.Location = new System.Drawing.Point(90, 21);
            this.combo_martes_fin.Name = "combo_martes_fin";
            this.combo_martes_fin.Size = new System.Drawing.Size(55, 21);
            this.combo_martes_fin.TabIndex = 19;
            this.combo_martes_fin.Text = "19:30";
            this.combo_martes_fin.SelectedIndexChanged += new System.EventHandler(this.combo_martes_fin_SelectedIndexChanged);
            // 
            // combo_lunes_fin
            // 
            this.combo_lunes_fin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_lunes_fin.FormattingEnabled = true;
            this.combo_lunes_fin.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_lunes_fin.Location = new System.Drawing.Point(10, 21);
            this.combo_lunes_fin.Name = "combo_lunes_fin";
            this.combo_lunes_fin.Size = new System.Drawing.Size(55, 21);
            this.combo_lunes_fin.TabIndex = 18;
            this.combo_lunes_fin.Text = "19:30";
            this.combo_lunes_fin.SelectedIndexChanged += new System.EventHandler(this.combo_lunes_fin_SelectedIndexChanged);
            // 
            // combo_sabado_inicio
            // 
            this.combo_sabado_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_sabado_inicio.FormattingEnabled = true;
            this.combo_sabado_inicio.Items.AddRange(new object[] {
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30"});
            this.combo_sabado_inicio.Location = new System.Drawing.Point(440, 23);
            this.combo_sabado_inicio.Name = "combo_sabado_inicio";
            this.combo_sabado_inicio.Size = new System.Drawing.Size(55, 21);
            this.combo_sabado_inicio.TabIndex = 13;
            this.combo_sabado_inicio.Text = "10:00";
            // 
            // combo_viernes_inicio
            // 
            this.combo_viernes_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_viernes_inicio.FormattingEnabled = true;
            this.combo_viernes_inicio.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_viernes_inicio.Location = new System.Drawing.Point(354, 23);
            this.combo_viernes_inicio.Name = "combo_viernes_inicio";
            this.combo_viernes_inicio.Size = new System.Drawing.Size(55, 21);
            this.combo_viernes_inicio.TabIndex = 12;
            this.combo_viernes_inicio.Text = "7:00";
            // 
            // combo_jueves_inicio
            // 
            this.combo_jueves_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_jueves_inicio.FormattingEnabled = true;
            this.combo_jueves_inicio.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_jueves_inicio.Location = new System.Drawing.Point(267, 23);
            this.combo_jueves_inicio.Name = "combo_jueves_inicio";
            this.combo_jueves_inicio.Size = new System.Drawing.Size(55, 21);
            this.combo_jueves_inicio.TabIndex = 11;
            this.combo_jueves_inicio.Text = "7:00";
            // 
            // combo_miercoles_inicio
            // 
            this.combo_miercoles_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_miercoles_inicio.FormattingEnabled = true;
            this.combo_miercoles_inicio.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_miercoles_inicio.Location = new System.Drawing.Point(178, 23);
            this.combo_miercoles_inicio.Name = "combo_miercoles_inicio";
            this.combo_miercoles_inicio.Size = new System.Drawing.Size(55, 21);
            this.combo_miercoles_inicio.TabIndex = 10;
            this.combo_miercoles_inicio.Text = "7:00";
            // 
            // combo_martes_inicio
            // 
            this.combo_martes_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_martes_inicio.FormattingEnabled = true;
            this.combo_martes_inicio.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_martes_inicio.Location = new System.Drawing.Point(92, 23);
            this.combo_martes_inicio.Name = "combo_martes_inicio";
            this.combo_martes_inicio.Size = new System.Drawing.Size(55, 21);
            this.combo_martes_inicio.TabIndex = 9;
            this.combo_martes_inicio.Text = "7:00";
            // 
            // combo_lunes_inicio
            // 
            this.combo_lunes_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_lunes_inicio.FormattingEnabled = true;
            this.combo_lunes_inicio.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.combo_lunes_inicio.Location = new System.Drawing.Point(12, 23);
            this.combo_lunes_inicio.Name = "combo_lunes_inicio";
            this.combo_lunes_inicio.Size = new System.Drawing.Size(55, 21);
            this.combo_lunes_inicio.TabIndex = 8;
            this.combo_lunes_inicio.Text = "7:00";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(440, 17);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(63, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Sábado";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(354, 17);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(61, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Viernes";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(267, 17);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Jueves";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(178, 17);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Miércoles";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(92, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Martes";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Lunes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(291, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 43);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Días";
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
            this.groupBox3.Size = new System.Drawing.Size(511, 58);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Horarios de Inicio";
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
            this.groupBox4.Size = new System.Drawing.Size(511, 57);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccionar Horario de Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Seleccionar Fecha de Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Seleccionar Fecha de Fin:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dateTimePicker2);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Location = new System.Drawing.Point(13, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 85);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Establecer Período";
            // 
            // frmRegistrarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 337);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarAgenda";
            this.Text = "Registrar Agenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
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
    }
}