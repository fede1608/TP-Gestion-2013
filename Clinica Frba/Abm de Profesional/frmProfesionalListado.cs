﻿using System;
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
        int tipo = 1;//tipo 3 == cancelar atencion !

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

            //SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            try
            {
                var result = runner
                    .Select("SELECT * FROM SIGKILL.profesional");
                
                var profesionalDb = new Adapter().TransformMany<Profesional>(result);

                IList<Especialidad> esp = new Adapter().TransformMany<Especialidad>(runner.Select("SELECT * FROM SIGKILL.especialidad WHERE esp_id>0"));
                foreach (Especialidad es in esp)
                {
                    combo_especialidad.Items.Add(es);

                }
                combo_especialidad.DisplayMember = ("esp_nombre_especialidad");
            }
            catch
            {
                MessageBox.Show("Error de profesional en la DB");
            }


            //Esto es para que al apretar enter (AcceptButton) se "clickee" el boton buscar
            this.AcceptButton = btn_ABMpro_buscar;
            //Esto es para que al apretar esc (cancelbutton) se "clickee" el boton limpiar
            this.CancelButton = btn_ABMpro_limpiar;

            switch (tipo)
            {
                case 1:
                    MessageBox.Show("Seleccione un profesional para modificar sus datos");
                    break;
                case 2:
                    MessageBox.Show("Seleccione un profesional para darlo de baja");
                    break;
                case 3:
                    MessageBox.Show("Seleccione un profesional para cancelar atenciones medicas");
                    break;
                case 4:
                    MessageBox.Show("Seleccione un profesional para registrar su agenda");
                    break;
            }
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
                filter.AddLike("pro_nombre", txt_ABMpro_nombre.Text);
            }

            if (txt_ABMpro_apellido.Text.Length > 0)
            {
                filter.AddLike("pro_apellido", txt_ABMpro_apellido.Text);
            }

            if (txt_ABMpro_dni.Text.Length > 0)
            {
                filter.AddEqual("pro_dni", txt_ABMpro_dni.Text);
            }

            if (combo_especialidad.SelectedIndex > 0)
            {
                filter.AddCustom("pro_id "," in "," (SELECT espprof_profesional FROM SIGKILL.esp_prof WHERE espprof_especialidad="+((Especialidad)combo_especialidad.SelectedItem).esp_id.ToString()+")");
            }
            filter.AddEqual("pro_habilitado", "1");
            try
            {
                var result = runner
                    .Select("SELECT pro_id, pro_matricula, pro_usuario, pro_nombre, pro_apellido, (SELECT tdoc_descripcion FROM SIGKILL.tipo_doc WHERE tdoc_id = pro_tipo_doc) as tipo_doc ,"+
                    "pro_dni as numero_doc, pro_direccion, pro_telefono, pro_mail, pro_nacimiento, pro_sexo, pro_cant_hs_acum, pro_habilitado FROM SIGKILL.profesional", filter);
                dbgrb_ABMpro_vistaListado.DataSource = result;

            }
            catch
            {
                MessageBox.Show("Hubo un error en la entrada de datos, por favor verifíquelos.");
            }
        }

        private void btn_ABMpro_limpiar_Click(object sender, EventArgs e)
        {
            dbgrb_ABMpro_vistaListado.DataSource = null;
        }

        private void dbgrb_ABMpro_vistaListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var cell = dbgrb_ABMpro_vistaListado.Rows[e.RowIndex];
           
            switch(tipo)
            { 
                    //1: Modificacion
                    //2:baja
                    //3:cancelar atencion medica - seleccionar profesional
            
                case 1:
                    var res = runner.Single("SELECT * FROM SIGKILL.profesional WHERE pro_id={0}", cell.Cells[0].Value.ToString());
                    Profesional pro = new Adapter().Transform<Profesional>(res);
                    new Clinica_Frba.Abm_de_Profesional_Alta.frm_ABMpro_Alta(pro).Show();
                    this.Close();
                    break;
            
                case 2:
                    DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar al profesional " + cell.Cells[1].Value.ToString() + "?", "Eliminar profesional", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            Profesional prof = new Adapter().Transform<Profesional>(runner.Single("SELECT * FROM SIGKILL.profesional WHERE pro_id={0}", cell.Cells[0].Value.ToString()));
                            prof.darDeBaja();
                            MessageBox.Show("Se ha eliminado correctamente al profesional");
                            btn_ABMpro_buscar_Click(new object(), new EventArgs());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                break;

                case 4://registrar agenda
                    new Clinica_Frba.Registrar_Agenda.frmRegistrarAgenda(Profesional.newFromId((long)cell.Cells[0].Value)).Show();
                    this.Close();
                    return;
                        
                //PARTE DE CANCELAR ATENCION
                case 3:
                    new Clinica_Frba.Cancelar_Atencion.frmCancelarTurno(Profesional.newFromId((long)cell.Cells[0].Value)).Show();
                    this.Close();
                return;

                //FIN CANCELAR ATENCION
            }
            
        }

        private void txt_ABMpro_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_ABMpro_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }



    }
}
