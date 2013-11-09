namespace Clinica_Frba.Listados_Estadisticos
{
    partial class frmListadosEstadisticos
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
            this.combo_semestre = new System.Windows.Forms.ComboBox();
            this.btn_top1 = new System.Windows.Forms.Button();
            this.btn_top2 = new System.Windows.Forms.Button();
            this.btn_top3 = new System.Windows.Forms.Button();
            this.btn_top4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_semestre
            // 
            this.combo_semestre.FormattingEnabled = true;
            this.combo_semestre.Items.AddRange(new object[] {
            "1er Semestre",
            "2do Semestre"});
            this.combo_semestre.Location = new System.Drawing.Point(31, 69);
            this.combo_semestre.Name = "combo_semestre";
            this.combo_semestre.Size = new System.Drawing.Size(121, 21);
            this.combo_semestre.TabIndex = 0;
            this.combo_semestre.SelectedIndexChanged += new System.EventHandler(this.combo_semestre_SelectedIndexChanged_1);
            // 
            // btn_top1
            // 
            this.btn_top1.Enabled = false;
            this.btn_top1.Location = new System.Drawing.Point(31, 113);
            this.btn_top1.Name = "btn_top1";
            this.btn_top1.Size = new System.Drawing.Size(236, 56);
            this.btn_top1.TabIndex = 1;
            this.btn_top1.Text = "Top 5 Cancelaciones por Especialidades";
            this.btn_top1.UseVisualStyleBackColor = true;
            this.btn_top1.Click += new System.EventHandler(this.btn_top1_Click);
            // 
            // btn_top2
            // 
            this.btn_top2.Enabled = false;
            this.btn_top2.Location = new System.Drawing.Point(286, 113);
            this.btn_top2.Name = "btn_top2";
            this.btn_top2.Size = new System.Drawing.Size(236, 56);
            this.btn_top2.TabIndex = 2;
            this.btn_top2.Text = "Top 5 Bonos Farmacias Vencidos por Afiliado";
            this.btn_top2.UseVisualStyleBackColor = true;
            this.btn_top2.Click += new System.EventHandler(this.btn_top2_Click);
            // 
            // btn_top3
            // 
            this.btn_top3.Enabled = false;
            this.btn_top3.Location = new System.Drawing.Point(31, 198);
            this.btn_top3.Name = "btn_top3";
            this.btn_top3.Size = new System.Drawing.Size(236, 56);
            this.btn_top3.TabIndex = 3;
            this.btn_top3.Text = "Top 5 Especialiades con mas Bonos Farmacias Recetados";
            this.btn_top3.UseVisualStyleBackColor = true;
            this.btn_top3.Click += new System.EventHandler(this.btn_top3_Click);
            // 
            // btn_top4
            // 
            this.btn_top4.Enabled = false;
            this.btn_top4.Location = new System.Drawing.Point(286, 198);
            this.btn_top4.Name = "btn_top4";
            this.btn_top4.Size = new System.Drawing.Size(236, 56);
            this.btn_top4.TabIndex = 4;
            this.btn_top4.Text = "Top 10 Afiliados que usaron bonos que ellos no compraron";
            this.btn_top4.UseVisualStyleBackColor = true;
            this.btn_top4.Click += new System.EventHandler(this.btn_top4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listados Estadísticos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_top4);
            this.groupBox1.Controls.Add(this.btn_top3);
            this.groupBox1.Controls.Add(this.btn_top2);
            this.groupBox1.Controls.Add(this.btn_top1);
            this.groupBox1.Controls.Add(this.combo_semestre);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 283);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas";
            // 
            // frmListadosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 316);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListadosEstadisticos";
            this.Text = "Listados Estadísticos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_semestre;
        private System.Windows.Forms.Button btn_top1;
        private System.Windows.Forms.Button btn_top2;
        private System.Windows.Forms.Button btn_top3;
        private System.Windows.Forms.Button btn_top4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}