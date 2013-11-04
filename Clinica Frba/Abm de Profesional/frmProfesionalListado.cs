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

namespace Clinica_Frba.Abm_de_Profesional_Listado
{
    public partial class frm_ABMpro_listado : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        int tipo = 1;

        public frm_ABMpro_listado()
        {
            InitializeComponent();
        }

        public frm_ABMpro_listado(int tipoRecibido)
        {
            InitializeComponent();
            tipo = tipoRecibido;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void lbl_ABMAfiliado_Listado_apellido_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ABMpro_seleccionarEspecialidad_Click(object sender, EventArgs e)
        {

        }

        private void frm_ABMpro_listado_Load(object sender, EventArgs e)
        {

            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            try
            {
                var result = runner
                    .Select("SELECT * FROM SIGKILL.profesional");
                var profesionalDb = new Adapter().TransformMany<Profesional>(result);


            }
            catch
            {
                MessageBox.Show("Error de profesional en la DB");
            }


            //Esto es para que al apretar enter (AcceptButton) se "clickee" el boton buscar
            this.AcceptButton = btn_ABMpro_buscar;
            //Esto es para que al apretar esc (cancelbutton) se "clickee" el boton limpiar
            this.CancelButton = btn_ABMpro_limpiar;

        }

        private void btn_ABMpro_buscar_Click(object sender, EventArgs e)
        {
            Filters filter = new Filters();
            
            if (txt_ABMpro_matricula.Text.Length > 0)
            {
                filter.AddEqual("pro_matricula", txt_ABMpro_matricula.Text);
            }

            if (txt_ABMpro_nombre.Text.Length > 0)
            {
                filter.AddEqual("pro_nombre", txt_ABMpro_nombre.Text);
            }

            if (txt_ABMpro_apellido.Text.Length > 0)
            {
                filter.AddEqual("pro_apellido", txt_ABMpro_apellido.Text);
            }

            if (txt_ABMpro_dni.Text.Length > 0)
            {
                filter.AddEqual("pro_dni", txt_ABMpro_dni.Text);
            }

            try
            {
                var result = runner
                    .Select("SELECT * FROM SIGKILL.profesional", filter);
                dbgrb_ABMpro_vistaListado.DataSource = result;

            }
            catch
            {
                MessageBox.Show("Error al buscar el profesional en la DB");
            }
        }

        private void btn_ABMpro_limpiar_Click(object sender, EventArgs e)
        {
            dbgrb_ABMpro_vistaListado.DataSource = null;
        }

        private void dbgrb_ABMpro_vistaListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dbgrb_ABMpro_vistaListado.Rows[e.RowIndex];
            //MessageBox.Show("Se clickeo " + cell.Cells[0].Value.ToString());
           /* if (tipo == 1)
            {
                var res = runner.Single("SELECT * FROM SIGKILL.profesional WHERE pro_matricula={0}", cell.Cells[0].Value.ToString());
                Profesional pro = new Adapter().Transform<Profesional>(res);
                new frm_ABMpro_listado(pro).Show();
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar al profesional " + cell.Cells[1].Value.ToString() + "?", "Eliminar profesional", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    runner.Delete("DELETE FROM SIGKILL.profesional WHERE pro_matricula={0}", cell.Cells[0].Value);
                    MessageBox.Show("Se ha eliminado correctamente al profesional");
                    btn_ABMpro_buscar_Click(new object(), new EventArgs());
                }
            }
            */
        }

    }
}
