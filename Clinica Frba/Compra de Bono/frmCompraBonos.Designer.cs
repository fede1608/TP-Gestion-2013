namespace Clinica_Frba.Compra_de_Bono
{
    partial class frmCompraBonos
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtFarmacia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotConsulta = new System.Windows.Forms.TextBox();
            this.txtTotFarmacia = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_precio_consulta = new System.Windows.Forms.Label();
            this.lbl_precio_farmacia = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(131, 41);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(72, 20);
            this.txtConsulta.TabIndex = 0;
            this.txtConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsulta_KeyUp);
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            // 
            // txtFarmacia
            // 
            this.txtFarmacia.Location = new System.Drawing.Point(131, 80);
            this.txtFarmacia.Name = "txtFarmacia";
            this.txtFarmacia.Size = new System.Drawing.Size(72, 20);
            this.txtFarmacia.TabIndex = 1;
            this.txtFarmacia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFarmacia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFarmacia_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bonos de Consulta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bonos de Farmacia:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtTotFarmacia);
            this.groupBox1.Controls.Add(this.txtTotConsulta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 252);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra de Bonos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // txtTotConsulta
            // 
            this.txtTotConsulta.Enabled = false;
            this.txtTotConsulta.Location = new System.Drawing.Point(334, 61);
            this.txtTotConsulta.Name = "txtTotConsulta";
            this.txtTotConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtTotConsulta.TabIndex = 5;
            this.txtTotConsulta.Text = "0";
            this.txtTotConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotFarmacia
            // 
            this.txtTotFarmacia.Enabled = false;
            this.txtTotFarmacia.Location = new System.Drawing.Point(334, 100);
            this.txtTotFarmacia.Name = "txtTotFarmacia";
            this.txtTotFarmacia.Size = new System.Drawing.Size(100, 20);
            this.txtTotFarmacia.TabIndex = 6;
            this.txtTotFarmacia.Text = "0";
            this.txtTotFarmacia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(334, 157);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(354, 212);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese Cantidad de Bonos a Comprar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_precio_farmacia);
            this.groupBox2.Controls.Add(this.lbl_precio_consulta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFarmacia);
            this.groupBox2.Controls.Add(this.txtConsulta);
            this.groupBox2.Location = new System.Drawing.Point(14, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "SubTotal:";
            // 
            // lbl_precio_consulta
            // 
            this.lbl_precio_consulta.AutoSize = true;
            this.lbl_precio_consulta.Location = new System.Drawing.Point(234, 44);
            this.lbl_precio_consulta.Name = "lbl_precio_consulta";
            this.lbl_precio_consulta.Size = new System.Drawing.Size(34, 13);
            this.lbl_precio_consulta.TabIndex = 10;
            this.lbl_precio_consulta.Text = "$0.00";
            // 
            // lbl_precio_farmacia
            // 
            this.lbl_precio_farmacia.AutoSize = true;
            this.lbl_precio_farmacia.Location = new System.Drawing.Point(234, 87);
            this.lbl_precio_farmacia.Name = "lbl_precio_farmacia";
            this.lbl_precio_farmacia.Size = new System.Drawing.Size(34, 13);
            this.lbl_precio_farmacia.TabIndex = 11;
            this.lbl_precio_farmacia.Text = "$0.00";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(29, 212);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frmCompraBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 272);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCompraBonos";
            this.Text = "Bonos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtFarmacia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotFarmacia;
        private System.Windows.Forms.TextBox txtTotConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_precio_farmacia;
        private System.Windows.Forms.Label lbl_precio_consulta;
    }
}