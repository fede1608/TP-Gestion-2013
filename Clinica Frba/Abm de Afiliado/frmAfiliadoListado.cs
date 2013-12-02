using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Sql;
using Clinica_Frba.ClasesDatosTablas;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class frmAfiliadoListado : Form
    {
        Boolean mod_o_baja=false;
        int tipo = 1;
        public frmAfiliadoListado(int type)
        {
            tipo = type;
            InitializeComponent();
        }
        public frmAfiliadoListado(Boolean mod_baja)
        {
            InitializeComponent();
            mod_o_baja = mod_baja;
            tipo = mod_baja ? 1 : 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

            var pmed = new Adapter().TransformMany<Plan_Medico>(runner.Select("SELECT * FROM SIGKILL.plan_medico"));
            foreach (Plan_Medico r in pmed)
            {
                cbo_Listado_planmedico.Items.Add(r);
            }
            cbo_Listado_planmedico.DisplayMember = "pmed_nombre";

            switch (tipo)
            {
                case 1:
                    MessageBox.Show("Seleccione un afiliado para modificar sus datos");
                    break;
                case 2:
                    MessageBox.Show("Seleccione un afiliado para darlo de baja");
                    break;
                case 3:
                    MessageBox.Show("Seleccione un afiliado para cancelar atenciones medicas");
                    break;
                case 4:
                    MessageBox.Show("Seleccione un afiliado para pedir un turno");
                    break;
                case 5:
                    MessageBox.Show("Seleccione un afiliado para comprar bonos");
                    break;
            }
        }

        private void btn_ABMAfiliado_Listado_Buscar_Click(object sender, EventArgs e)
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

            Filters filter = new Filters();
            filter.AddEqualField("afil_estado_civil", "estciv_id");
            filter.AddEqualField("afil_id_plan_medico", "pmed_id");
            filter.AddEqualField("afil_tipo_doc", "tdoc_id");
            if (txt_Listado_nroafiliado.Text.Length > 0)
            {
                filter.AddEqualField("afil_numero", txt_Listado_nroafiliado.Text);
            }
            if (txt_Listado_nombre.Text.Length > 0)
            {
                filter.AddLike("afil_nombre", txt_Listado_nombre.Text);
            }
            if (txt_Listado_apellido.Text.Length > 0)
            {
                filter.AddLike("afil_apellido", txt_Listado_apellido.Text);
            }
            if (txt_Listado_nrodoc.Text.Length > 0)
            {
                filter.AddEqualField("afil_dni", txt_Listado_nrodoc.Text);
            }
            if (cbo_Listado_planmedico.Text.Length > 0)
            {
                Plan_Medico plan_med = (Plan_Medico)cbo_Listado_planmedico.SelectedItem;
                filter.AddEqualField("afil_id_plan_medico", plan_med.pmed_id.ToString());
            }
            filter.AddEqualField("afil_activo", "1");
            try
            {
                var result = runner
                    .Select("SELECT [afil_numero] as Numero_Afiliado,[afil_usuario] as Usuario,[afil_nombre] as Nombre      ,[afil_apellido] as Apellido      ,[tdoc_descripcion] as Tipo_Doc       ,[afil_dni] as DNI      ,[afil_direccion] as Direccion      ,[afil_telefono] as Telefono      ,[afil_mail] as Mail      ,[afil_nacimiento] as Fecha_Nacimiento      ,[afil_sexo] as Sexo      ,[estciv_descripcion] as Estado_Civil      ,[afil_cant_hijos] as Cantidad_de_hijos      ,[afil_cant_fam_a_cargo] as Cantidad_de_familiares      ,[pmed_nombre] as Plan_medico  FROM SIGKILL.afiliado,SIGKILL.estado_civil,SIGKILL.tipo_doc,SIGKILL.plan_medico ", filter);
                dbgrb_ABMAfiliado_Listado_vista.DataSource = result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Listado_limpiar_Click(object sender, EventArgs e)
        {
            txt_Listado_apellido.Clear();
            txt_Listado_nombre.Clear();
            txt_Listado_nroafiliado.Clear();
            txt_Listado_nrodoc.Clear();
            dbgrb_ABMAfiliado_Listado_vista.DataSource = null;
        }

        private void dbgrb_ABMAfiliado_Listado_vista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

            var cell = dbgrb_ABMAfiliado_Listado_vista.Rows[e.RowIndex];

            switch(tipo)
            {
                case 3:
                    new Clinica_Frba.Cancelar_Atencion.frmCancelarTurno(Afiliado.newFromId((long)cell.Cells[0].Value)).Show();
                    this.Close();
                    return;
                case 4:
                    new Clinica_Frba.Pedir_Turno.frmSolicitarTurno(Afiliado.newFromId((long)cell.Cells[0].Value)).Show();
                    this.Close();
                    return;
                case 5:
                    new Clinica_Frba.Compra_de_Bono.frmCompraBonos(Usuario.newFromId(Afiliado.newFromId((long)cell.Cells[0].Value).afil_usuario)).Show();
                    this.Close();
                    return;
            }
            var res = runner.Single("SELECT * FROM SIGKILL.afiliado WHERE afil_numero={0}", cell.Cells[0].Value.ToString());
            //Afiliado afil = new Adapter().Transform<Afiliado>(res);
            if (mod_o_baja)
                new frmAfiliadoAltaMod((long)cell.Cells[0].Value).Show();
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar al Afiliado?", "Eliminar Afiliado", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Afiliado afiliado_baja = Afiliado.newFromId((long)cell.Cells[0].Value);
                        afiliado_baja.darDeBaja();
                        MessageBox.Show("El afiliado fue dado de baja correctamente");
                        btn_ABMAfiliado_Listado_Buscar_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void txt_Listado_nroafiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
