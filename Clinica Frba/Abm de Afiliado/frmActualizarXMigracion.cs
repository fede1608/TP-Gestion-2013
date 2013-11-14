using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ClasesDatosTablas;
using Clinica_Frba.Sql;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class frmActualizarXMigracion : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        Afiliado afiliado;
        public frmActualizarXMigracion(Afiliado a)
        {
            afiliado = a;
            InitializeComponent();
        }

        private void frmActualizarXMigracion_Load(object sender, EventArgs e)
        {
            lbl_afiliado.Text = afiliado.getName();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0)
            {
                try
                {
                    runner.Update("UPDATE SIGKILL.afiliado SET afil_nacimiento='{0}', afil_tipo_doc={1},afil_sexo='{2}' WHERE afil_numero={3}", dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox1.SelectedIndex + 1, comboBox2.SelectedIndex + 1, afiliado.afil_numero);
                    MessageBox.Show("Se han actualizados los datos. Muchas Gracias");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}
