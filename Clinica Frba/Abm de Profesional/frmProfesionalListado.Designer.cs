namespace Clinica_Frba.Abm_de_Profesional_Listado
{
    partial class frm_ABMpro_listado
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
            this.dbgrb_ABMpro_vistaListado = new System.Windows.Forms.DataGridView();
            this.gbox_ABMpro_filtros = new System.Windows.Forms.GroupBox();
            this.txt_ABMpro_matricula = new System.Windows.Forms.TextBox();
            this.txt_ABMpro_nombre = new System.Windows.Forms.TextBox();
            this.txt_ABMpro_apellido = new System.Windows.Forms.TextBox();
            this.txt_ABMpro_dni = new System.Windows.Forms.TextBox();
            this.btn_ABMpro_seleccionarEspecialidad = new System.Windows.Forms.Button();
            this.lbl_ABMpro_listado = new System.Windows.Forms.Label();
            this.lbl_ABMpro_dni = new System.Windows.Forms.Label();
            this.lbl_ABMpro_apellido = new System.Windows.Forms.Label();
            this.lbl_ABMpro_nombre = new System.Windows.Forms.Label();
            this.lbl_ABMpro_matricula = new System.Windows.Forms.Label();
            this.btn_ABMpro_limpiar = new System.Windows.Forms.Button();
            this.btn_ABMpro_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrb_ABMpro_vistaListado)).BeginInit();
            this.gbox_ABMpro_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbgrb_ABMpro_vistaListado
            // 
            this.dbgrb_ABMpro_vistaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrb_ABMpro_vistaListado.Location = new System.Drawing.Point(14, 194);
            this.dbgrb_ABMpro_vistaListado.Name = "dbgrb_ABMpro_vistaListado";
            this.dbgrb_ABMpro_vistaListado.Size = new System.Drawing.Size(522, 208);
            this.dbgrb_ABMpro_vistaListado.TabIndex = 0;
            // 
            // gbox_ABMpro_filtros
            // 
            this.gbox_ABMpro_filtros.Controls.Add(this.txt_ABMpro_matricula);
            this.gbox_ABMpro_filtros.Controls.Add(this.txt_ABMpro_nombre);
            this.gbox_ABMpro_filtros.Controls.Add(this.txt_ABMpro_apellido);
            this.gbox_ABMpro_filtros.Controls.Add(this.txt_ABMpro_dni);
            this.gbox_ABMpro_filtros.Controls.Add(this.btn_ABMpro_seleccionarEspecialidad);
            this.gbox_ABMpro_filtros.Controls.Add(this.lbl_ABMpro_listado);
            this.gbox_ABMpro_filtros.Controls.Add(this.lbl_ABMpro_dni);
            this.gbox_ABMpro_filtros.Controls.Add(this.lbl_ABMpro_apellido);
            this.gbox_ABMpro_filtros.Controls.Add(this.lbl_ABMpro_nombre);
            this.gbox_ABMpro_filtros.Controls.Add(this.lbl_ABMpro_matricula);
            this.gbox_ABMpro_filtros.Location = new System.Drawing.Point(12, 12);
            this.gbox_ABMpro_filtros.Name = "gbox_ABMpro_filtros";
            this.gbox_ABMpro_filtros.Size = new System.Drawing.Size(522, 130);
            this.gbox_ABMpro_filtros.TabIndex = 1;
            this.gbox_ABMpro_filtros.TabStop = false;
            this.gbox_ABMpro_filtros.Text = "Filtros de búsqueda";
            this.gbox_ABMpro_filtros.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // txt_ABMpro_apellido
            // 
            this.txt_ABMpro_apellido.Location = new System.Drawing.Point(89, 88);
            this.txt_ABMpro_apellido.Name = "txt_ABMpro_apellido";
            this.txt_ABMpro_apellido.Size = new System.Drawing.Size(159, 20);
            this.txt_ABMpro_apellido.TabIndex = 7;
            // 
            // txt_ABMpro_dni
            // 
            this.txt_ABMpro_dni.Location = new System.Drawing.Point(344, 23);
            this.txt_ABMpro_dni.Name = "txt_ABMpro_dni";
            this.txt_ABMpro_dni.Size = new System.Drawing.Size(152, 20);
            this.txt_ABMpro_dni.TabIndex = 6;
            // 
            // btn_ABMpro_seleccionarEspecialidad
            // 
            this.btn_ABMpro_seleccionarEspecialidad.Location = new System.Drawing.Point(344, 54);
            this.btn_ABMpro_seleccionarEspecialidad.Name = "btn_ABMpro_seleccionarEspecialidad";
            this.btn_ABMpro_seleccionarEspecialidad.Size = new System.Drawing.Size(152, 23);
            this.btn_ABMpro_seleccionarEspecialidad.TabIndex = 5;
            this.btn_ABMpro_seleccionarEspecialidad.Text = "Seleccionar";
            this.btn_ABMpro_seleccionarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // lbl_ABMpro_listado
            // 
            this.lbl_ABMpro_listado.AutoSize = true;
            this.lbl_ABMpro_listado.Location = new System.Drawing.Point(273, 58);
            this.lbl_ABMpro_listado.Name = "lbl_ABMpro_listado";
            this.lbl_ABMpro_listado.Size = new System.Drawing.Size(65, 13);
            this.lbl_ABMpro_listado.TabIndex = 4;
            this.lbl_ABMpro_listado.Text = "Plan médico";
            // 
            // lbl_ABMpro_dni
            // 
            this.lbl_ABMpro_dni.AutoSize = true;
            this.lbl_ABMpro_dni.Location = new System.Drawing.Point(273, 26);
            this.lbl_ABMpro_dni.Name = "lbl_ABMpro_dni";
            this.lbl_ABMpro_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_ABMpro_dni.TabIndex = 3;
            this.lbl_ABMpro_dni.Text = "DNI";
            // 
            // lbl_ABMpro_apellido
            // 
            this.lbl_ABMpro_apellido.AutoSize = true;
            this.lbl_ABMpro_apellido.Location = new System.Drawing.Point(23, 91);
            this.lbl_ABMpro_apellido.Name = "lbl_ABMpro_apellido";
            this.lbl_ABMpro_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_ABMpro_apellido.TabIndex = 2;
            this.lbl_ABMpro_apellido.Text = "Apellido";
            this.lbl_ABMpro_apellido.Click += new System.EventHandler(this.lbl_ABMAfiliado_Listado_apellido_Click);
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
            // btn_ABMpro_limpiar
            // 
            this.btn_ABMpro_limpiar.Location = new System.Drawing.Point(12, 148);
            this.btn_ABMpro_limpiar.Name = "btn_ABMpro_limpiar";
            this.btn_ABMpro_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_ABMpro_limpiar.TabIndex = 2;
            this.btn_ABMpro_limpiar.Text = "Limpiar";
            this.btn_ABMpro_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_ABMpro_buscar
            // 
            this.btn_ABMpro_buscar.Location = new System.Drawing.Point(462, 148);
            this.btn_ABMpro_buscar.Name = "btn_ABMpro_buscar";
            this.btn_ABMpro_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_ABMpro_buscar.TabIndex = 3;
            this.btn_ABMpro_buscar.Text = "Buscar";
            this.btn_ABMpro_buscar.UseVisualStyleBackColor = true;
            // 
            // frm_ABMpro_listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 414);
            this.Controls.Add(this.btn_ABMpro_buscar);
            this.Controls.Add(this.btn_ABMpro_limpiar);
            this.Controls.Add(this.gbox_ABMpro_filtros);
            this.Controls.Add(this.dbgrb_ABMpro_vistaListado);
            this.Name = "frm_ABMpro_listado";
            this.Text = "Listado de profesionales";
            ((System.ComponentModel.ISupportInitialize)(this.dbgrb_ABMpro_vistaListado)).EndInit();
            this.gbox_ABMpro_filtros.ResumeLayout(false);
            this.gbox_ABMpro_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgrb_ABMpro_vistaListado;
        private System.Windows.Forms.GroupBox gbox_ABMpro_filtros;
        private System.Windows.Forms.Button btn_ABMpro_limpiar;
        private System.Windows.Forms.Button btn_ABMpro_buscar;
        private System.Windows.Forms.Label lbl_ABMpro_dni;
        private System.Windows.Forms.Label lbl_ABMpro_apellido;
        private System.Windows.Forms.Label lbl_ABMpro_nombre;
        private System.Windows.Forms.Label lbl_ABMpro_matricula;
        private System.Windows.Forms.Label lbl_ABMpro_listado;
        private System.Windows.Forms.TextBox txt_ABMpro_matricula;
        private System.Windows.Forms.TextBox txt_ABMpro_nombre;
        private System.Windows.Forms.TextBox txt_ABMpro_apellido;
        private System.Windows.Forms.TextBox txt_ABMpro_dni;
        private System.Windows.Forms.Button btn_ABMpro_seleccionarEspecialidad;
    }
}