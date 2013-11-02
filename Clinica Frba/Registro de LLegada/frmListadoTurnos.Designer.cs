namespace Clinica_Frba.Registro_de_LLegada
{
    partial class frmListadoTurnos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom_afil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ape_afil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nom_prof = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ape_prof = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_especialidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_num_afil = new System.Windows.Forms.TextBox();
            this.chk_hoy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(768, 160);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(12, 134);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(705, 134);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_hoy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_num_afil);
            this.groupBox1.Controls.Add(this.combo_especialidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ape_prof);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nom_prof);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ape_afil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nom_afil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Turno:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Afiliado:";
            // 
            // txt_nom_afil
            // 
            this.txt_nom_afil.Location = new System.Drawing.Point(358, 28);
            this.txt_nom_afil.Name = "txt_nom_afil";
            this.txt_nom_afil.Size = new System.Drawing.Size(100, 20);
            this.txt_nom_afil.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido Afiliado:";
            // 
            // txt_ape_afil
            // 
            this.txt_ape_afil.Location = new System.Drawing.Point(357, 55);
            this.txt_ape_afil.Name = "txt_ape_afil";
            this.txt_ape_afil.Size = new System.Drawing.Size(100, 20);
            this.txt_ape_afil.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre Profesional:";
            // 
            // txt_nom_prof
            // 
            this.txt_nom_prof.Location = new System.Drawing.Point(638, 28);
            this.txt_nom_prof.Name = "txt_nom_prof";
            this.txt_nom_prof.Size = new System.Drawing.Size(117, 20);
            this.txt_nom_prof.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido Profesional:";
            // 
            // txt_ape_prof
            // 
            this.txt_ape_prof.Location = new System.Drawing.Point(638, 54);
            this.txt_ape_prof.Name = "txt_ape_prof";
            this.txt_ape_prof.Size = new System.Drawing.Size(117, 20);
            this.txt_ape_prof.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Especialidad:";
            // 
            // combo_especialidad
            // 
            this.combo_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_especialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_especialidad.FormattingEnabled = true;
            this.combo_especialidad.Location = new System.Drawing.Point(638, 81);
            this.combo_especialidad.Name = "combo_especialidad";
            this.combo_especialidad.Size = new System.Drawing.Size(117, 21);
            this.combo_especialidad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero Afiliado:";
            // 
            // txt_num_afil
            // 
            this.txt_num_afil.Location = new System.Drawing.Point(357, 81);
            this.txt_num_afil.Name = "txt_num_afil";
            this.txt_num_afil.Size = new System.Drawing.Size(100, 20);
            this.txt_num_afil.TabIndex = 13;
            // 
            // chk_hoy
            // 
            this.chk_hoy.AutoSize = true;
            this.chk_hoy.Checked = true;
            this.chk_hoy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_hoy.Location = new System.Drawing.Point(60, 71);
            this.chk_hoy.Name = "chk_hoy";
            this.chk_hoy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_hoy.Size = new System.Drawing.Size(121, 17);
            this.chk_hoy.TabIndex = 15;
            this.chk_hoy.Text = "Sólo Turnos del Día";
            this.chk_hoy.UseVisualStyleBackColor = true;
            // 
            // frmListadoTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListadoTurnos";
            this.Text = "Listado de Turnos";
            this.Load += new System.EventHandler(this.frmListadoTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nom_prof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ape_afil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom_afil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ape_prof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_num_afil;
        private System.Windows.Forms.ComboBox combo_especialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_hoy;
    }
}