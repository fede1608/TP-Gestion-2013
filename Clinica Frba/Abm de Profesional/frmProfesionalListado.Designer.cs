namespace Clinica_Frba.Abm_de_Afiliado_Listado
{
    partial class frmAfiliadoListado
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
            this.dbgrb_ABMAfiliado_Listado_vista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ABMpro_matricula = new System.Windows.Forms.TextBox();
            this.txt_ABMpro_nombre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ABMAfiliado_Listado_seleccionarplan = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_ABMAfiliado_Listado_planmedico = new System.Windows.Forms.Label();
            this.lbl_ABMAfiliado_Listado_dni = new System.Windows.Forms.Label();
            this.lbl_ABMAfiliado_Listado_apellido = new System.Windows.Forms.Label();
            this.lbl_ABMpro_nombre = new System.Windows.Forms.Label();
            this.lbl_ABMpro_matricula = new System.Windows.Forms.Label();
            this.btn_ABMAfiliado_Listado_limpiar = new System.Windows.Forms.Button();
            this.btn_ABMAfiliado_Listado_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrb_ABMAfiliado_Listado_vista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbgrb_ABMAfiliado_Listado_vista
            // 
            this.dbgrb_ABMAfiliado_Listado_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrb_ABMAfiliado_Listado_vista.Location = new System.Drawing.Point(14, 194);
            this.dbgrb_ABMAfiliado_Listado_vista.Name = "dbgrb_ABMAfiliado_Listado_vista";
            this.dbgrb_ABMAfiliado_Listado_vista.Size = new System.Drawing.Size(522, 208);
            this.dbgrb_ABMAfiliado_Listado_vista.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ABMpro_matricula);
            this.groupBox1.Controls.Add(this.txt_ABMpro_nombre);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_ABMAfiliado_Listado_seleccionarplan);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbl_ABMAfiliado_Listado_planmedico);
            this.groupBox1.Controls.Add(this.lbl_ABMAfiliado_Listado_dni);
            this.groupBox1.Controls.Add(this.lbl_ABMAfiliado_Listado_apellido);
            this.groupBox1.Controls.Add(this.lbl_ABMpro_nombre);
            this.groupBox1.Controls.Add(this.lbl_ABMpro_matricula);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_ABMpro_matricula
            // 
            this.txt_ABMpro_matricula.Location = new System.Drawing.Point(89, 23);
            this.txt_ABMpro_matricula.Name = "txt_ABMpro_matricula";
            this.txt_ABMpro_matricula.Size = new System.Drawing.Size(159, 20);
            this.txt_ABMpro_matricula.TabIndex = 9;
            // 
            // txt_ABMpro_nombre
            // 
            this.txt_ABMpro_nombre.Location = new System.Drawing.Point(89, 55);
            this.txt_ABMpro_nombre.Name = "txt_ABMpro_nombre";
            this.txt_ABMpro_nombre.Size = new System.Drawing.Size(159, 20);
            this.txt_ABMpro_nombre.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btn_ABMAfiliado_Listado_seleccionarplan
            // 
            this.btn_ABMAfiliado_Listado_seleccionarplan.Location = new System.Drawing.Point(421, 54);
            this.btn_ABMAfiliado_Listado_seleccionarplan.Name = "btn_ABMAfiliado_Listado_seleccionarplan";
            this.btn_ABMAfiliado_Listado_seleccionarplan.Size = new System.Drawing.Size(75, 23);
            this.btn_ABMAfiliado_Listado_seleccionarplan.TabIndex = 5;
            this.btn_ABMAfiliado_Listado_seleccionarplan.Text = "Seleccionar";
            this.btn_ABMAfiliado_Listado_seleccionarplan.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lbl_ABMAfiliado_Listado_planmedico
            // 
            this.lbl_ABMAfiliado_Listado_planmedico.AutoSize = true;
            this.lbl_ABMAfiliado_Listado_planmedico.Location = new System.Drawing.Point(273, 58);
            this.lbl_ABMAfiliado_Listado_planmedico.Name = "lbl_ABMAfiliado_Listado_planmedico";
            this.lbl_ABMAfiliado_Listado_planmedico.Size = new System.Drawing.Size(65, 13);
            this.lbl_ABMAfiliado_Listado_planmedico.TabIndex = 4;
            this.lbl_ABMAfiliado_Listado_planmedico.Text = "Plan médico";
            // 
            // lbl_ABMAfiliado_Listado_dni
            // 
            this.lbl_ABMAfiliado_Listado_dni.AutoSize = true;
            this.lbl_ABMAfiliado_Listado_dni.Location = new System.Drawing.Point(273, 26);
            this.lbl_ABMAfiliado_Listado_dni.Name = "lbl_ABMAfiliado_Listado_dni";
            this.lbl_ABMAfiliado_Listado_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_ABMAfiliado_Listado_dni.TabIndex = 3;
            this.lbl_ABMAfiliado_Listado_dni.Text = "DNI";
            // 
            // lbl_ABMAfiliado_Listado_apellido
            // 
            this.lbl_ABMAfiliado_Listado_apellido.AutoSize = true;
            this.lbl_ABMAfiliado_Listado_apellido.Location = new System.Drawing.Point(23, 91);
            this.lbl_ABMAfiliado_Listado_apellido.Name = "lbl_ABMAfiliado_Listado_apellido";
            this.lbl_ABMAfiliado_Listado_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_ABMAfiliado_Listado_apellido.TabIndex = 2;
            this.lbl_ABMAfiliado_Listado_apellido.Text = "Apellido";
            this.lbl_ABMAfiliado_Listado_apellido.Click += new System.EventHandler(this.lbl_ABMAfiliado_Listado_apellido_Click);
            // 
            // lbl_ABMpro_nombre
            // 
            this.lbl_ABMpro_nombre.AutoSize = true;
            this.lbl_ABMpro_nombre.Location = new System.Drawing.Point(23, 58);
            this.lbl_ABMpro_nombre.Name = "lbl_ABMpro_nombre";
            this.lbl_ABMpro_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_ABMpro_nombre.TabIndex = 1;
            this.lbl_ABMpro_nombre.Text = "Nombre";
            // 
            // lbl_ABMpro_matricula
            // 
            this.lbl_ABMpro_matricula.AutoSize = true;
            this.lbl_ABMpro_matricula.Location = new System.Drawing.Point(23, 26);
            this.lbl_ABMpro_matricula.Name = "lbl_ABMpro_matricula";
            this.lbl_ABMpro_matricula.Size = new System.Drawing.Size(52, 13);
            this.lbl_ABMpro_matricula.TabIndex = 0;
            this.lbl_ABMpro_matricula.Text = "Matrícula";
            this.lbl_ABMpro_matricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ABMAfiliado_Listado_limpiar
            // 
            this.btn_ABMAfiliado_Listado_limpiar.Location = new System.Drawing.Point(12, 148);
            this.btn_ABMAfiliado_Listado_limpiar.Name = "btn_ABMAfiliado_Listado_limpiar";
            this.btn_ABMAfiliado_Listado_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_ABMAfiliado_Listado_limpiar.TabIndex = 2;
            this.btn_ABMAfiliado_Listado_limpiar.Text = "Limpiar";
            this.btn_ABMAfiliado_Listado_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_ABMAfiliado_Listado_Buscar
            // 
            this.btn_ABMAfiliado_Listado_Buscar.Location = new System.Drawing.Point(462, 148);
            this.btn_ABMAfiliado_Listado_Buscar.Name = "btn_ABMAfiliado_Listado_Buscar";
            this.btn_ABMAfiliado_Listado_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_ABMAfiliado_Listado_Buscar.TabIndex = 3;
            this.btn_ABMAfiliado_Listado_Buscar.Text = "Buscar";
            this.btn_ABMAfiliado_Listado_Buscar.UseVisualStyleBackColor = true;
            // 
            // frmAfiliadoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 414);
            this.Controls.Add(this.btn_ABMAfiliado_Listado_Buscar);
            this.Controls.Add(this.btn_ABMAfiliado_Listado_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dbgrb_ABMAfiliado_Listado_vista);
            this.Name = "frmAfiliadoListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrb_ABMAfiliado_Listado_vista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgrb_ABMAfiliado_Listado_vista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ABMAfiliado_Listado_limpiar;
        private System.Windows.Forms.Button btn_ABMAfiliado_Listado_Buscar;
        private System.Windows.Forms.Label lbl_ABMAfiliado_Listado_dni;
        private System.Windows.Forms.Label lbl_ABMAfiliado_Listado_apellido;
        private System.Windows.Forms.Label lbl_ABMpro_nombre;
        private System.Windows.Forms.Label lbl_ABMpro_matricula;
        private System.Windows.Forms.Label lbl_ABMAfiliado_Listado_planmedico;
        private System.Windows.Forms.TextBox txt_ABMpro_matricula;
        private System.Windows.Forms.TextBox txt_ABMpro_nombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ABMAfiliado_Listado_seleccionarplan;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}