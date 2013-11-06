namespace Clinica_Frba.Abm_de_Afiliado
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
            this.txt_Listado_nroafiliado = new System.Windows.Forms.TextBox();
            this.txt_Listado_nombre = new System.Windows.Forms.TextBox();
            this.txt_Listado_apellido = new System.Windows.Forms.TextBox();
            this.txt_Listado_nrodoc = new System.Windows.Forms.TextBox();
            this.cbo_Listado_planmedico = new System.Windows.Forms.ComboBox();
            this.lbl_ABMAfiliado_Listado_planmedico = new System.Windows.Forms.Label();
            this.lbl_ABMAfiliado_Listado_dni = new System.Windows.Forms.Label();
            this.lbl_ABMAfiliado_Listado_apellido = new System.Windows.Forms.Label();
            this.lbl_ABMAfiliado_Listado_nombre = new System.Windows.Forms.Label();
            this.lbl_ABMAfiliado_Listado_nroafiliado = new System.Windows.Forms.Label();
            this.btn_Listado_limpiar = new System.Windows.Forms.Button();
            this.btn_Listado_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrb_ABMAfiliado_Listado_vista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbgrb_ABMAfiliado_Listado_vista
            // 
            this.dbgrb_ABMAfiliado_Listado_vista.AllowUserToAddRows = false;
            this.dbgrb_ABMAfiliado_Listado_vista.AllowUserToDeleteRows = false;
            this.dbgrb_ABMAfiliado_Listado_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrb_ABMAfiliado_Listado_vista.Location = new System.Drawing.Point(14, 194);
            this.dbgrb_ABMAfiliado_Listado_vista.Name = "dbgrb_ABMAfiliado_Listado_vista";
            this.dbgrb_ABMAfiliado_Listado_vista.ReadOnly = true;
            this.dbgrb_ABMAfiliado_Listado_vista.Size = new System.Drawing.Size(522, 208);
            this.dbgrb_ABMAfiliado_Listado_vista.TabIndex = 0;
            this.dbgrb_ABMAfiliado_Listado_vista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrb_ABMAfiliado_Listado_vista_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Listado_nroafiliado);
            this.groupBox1.Controls.Add(this.txt_Listado_nombre);
            this.groupBox1.Controls.Add(this.txt_Listado_apellido);
            this.groupBox1.Controls.Add(this.txt_Listado_nrodoc);
            this.groupBox1.Controls.Add(this.cbo_Listado_planmedico);
            this.groupBox1.Controls.Add(this.lbl_ABMAfiliado_Listado_planmedico);
            this.groupBox1.Controls.Add(this.lbl_ABMAfiliado_Listado_dni);
            this.groupBox1.Controls.Add(this.lbl_ABMAfiliado_Listado_apellido);
            this.groupBox1.Controls.Add(this.lbl_ABMAfiliado_Listado_nombre);
            this.groupBox1.Controls.Add(this.lbl_ABMAfiliado_Listado_nroafiliado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // txt_Listado_nroafiliado
            // 
            this.txt_Listado_nroafiliado.Location = new System.Drawing.Point(89, 23);
            this.txt_Listado_nroafiliado.Name = "txt_Listado_nroafiliado";
            this.txt_Listado_nroafiliado.Size = new System.Drawing.Size(159, 20);
            this.txt_Listado_nroafiliado.TabIndex = 9;
            // 
            // txt_Listado_nombre
            // 
            this.txt_Listado_nombre.Location = new System.Drawing.Point(89, 55);
            this.txt_Listado_nombre.Name = "txt_Listado_nombre";
            this.txt_Listado_nombre.Size = new System.Drawing.Size(159, 20);
            this.txt_Listado_nombre.TabIndex = 8;
            // 
            // txt_Listado_apellido
            // 
            this.txt_Listado_apellido.Location = new System.Drawing.Point(89, 88);
            this.txt_Listado_apellido.Name = "txt_Listado_apellido";
            this.txt_Listado_apellido.Size = new System.Drawing.Size(159, 20);
            this.txt_Listado_apellido.TabIndex = 7;
            // 
            // txt_Listado_nrodoc
            // 
            this.txt_Listado_nrodoc.Location = new System.Drawing.Point(344, 23);
            this.txt_Listado_nrodoc.Name = "txt_Listado_nrodoc";
            this.txt_Listado_nrodoc.Size = new System.Drawing.Size(152, 20);
            this.txt_Listado_nrodoc.TabIndex = 6;
            // 
            // cbo_Listado_planmedico
            // 
            this.cbo_Listado_planmedico.FormattingEnabled = true;
            this.cbo_Listado_planmedico.Location = new System.Drawing.Point(344, 55);
            this.cbo_Listado_planmedico.Name = "cbo_Listado_planmedico";
            this.cbo_Listado_planmedico.Size = new System.Drawing.Size(152, 21);
            this.cbo_Listado_planmedico.TabIndex = 4;
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
            // 
            // lbl_ABMAfiliado_Listado_nombre
            // 
            this.lbl_ABMAfiliado_Listado_nombre.AutoSize = true;
            this.lbl_ABMAfiliado_Listado_nombre.Location = new System.Drawing.Point(23, 58);
            this.lbl_ABMAfiliado_Listado_nombre.Name = "lbl_ABMAfiliado_Listado_nombre";
            this.lbl_ABMAfiliado_Listado_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_ABMAfiliado_Listado_nombre.TabIndex = 1;
            this.lbl_ABMAfiliado_Listado_nombre.Text = "Nombre";
            // 
            // lbl_ABMAfiliado_Listado_nroafiliado
            // 
            this.lbl_ABMAfiliado_Listado_nroafiliado.AutoSize = true;
            this.lbl_ABMAfiliado_Listado_nroafiliado.Location = new System.Drawing.Point(23, 26);
            this.lbl_ABMAfiliado_Listado_nroafiliado.Name = "lbl_ABMAfiliado_Listado_nroafiliado";
            this.lbl_ABMAfiliado_Listado_nroafiliado.Size = new System.Drawing.Size(56, 13);
            this.lbl_ABMAfiliado_Listado_nroafiliado.TabIndex = 0;
            this.lbl_ABMAfiliado_Listado_nroafiliado.Text = "Nº Afiliado";
            this.lbl_ABMAfiliado_Listado_nroafiliado.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Listado_limpiar
            // 
            this.btn_Listado_limpiar.Location = new System.Drawing.Point(12, 148);
            this.btn_Listado_limpiar.Name = "btn_Listado_limpiar";
            this.btn_Listado_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Listado_limpiar.TabIndex = 2;
            this.btn_Listado_limpiar.Text = "Limpiar";
            this.btn_Listado_limpiar.UseVisualStyleBackColor = true;
            this.btn_Listado_limpiar.Click += new System.EventHandler(this.btn_Listado_limpiar_Click);
            // 
            // btn_Listado_buscar
            // 
            this.btn_Listado_buscar.Location = new System.Drawing.Point(462, 148);
            this.btn_Listado_buscar.Name = "btn_Listado_buscar";
            this.btn_Listado_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Listado_buscar.TabIndex = 3;
            this.btn_Listado_buscar.Text = "Buscar";
            this.btn_Listado_buscar.UseVisualStyleBackColor = true;
            this.btn_Listado_buscar.Click += new System.EventHandler(this.btn_ABMAfiliado_Listado_Buscar_Click);
            // 
            // frmAfiliadoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 414);
            this.Controls.Add(this.btn_Listado_buscar);
            this.Controls.Add(this.btn_Listado_limpiar);
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
        private System.Windows.Forms.Button btn_Listado_limpiar;
        private System.Windows.Forms.Button btn_Listado_buscar;
        private System.Windows.Forms.Label lbl_ABMAfiliado_Listado_dni;
        private System.Windows.Forms.Label lbl_ABMAfiliado_Listado_apellido;
        private System.Windows.Forms.Label lbl_ABMAfiliado_Listado_nombre;
        private System.Windows.Forms.Label lbl_ABMAfiliado_Listado_nroafiliado;
        private System.Windows.Forms.Label lbl_ABMAfiliado_Listado_planmedico;
        private System.Windows.Forms.TextBox txt_Listado_nroafiliado;
        private System.Windows.Forms.TextBox txt_Listado_nombre;
        private System.Windows.Forms.TextBox txt_Listado_apellido;
        private System.Windows.Forms.TextBox txt_Listado_nrodoc;
        private System.Windows.Forms.ComboBox cbo_Listado_planmedico;
    }
}