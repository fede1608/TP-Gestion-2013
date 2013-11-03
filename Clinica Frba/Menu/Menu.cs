using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Login;
using Clinica_Frba.ClasesDatosTablas;

namespace Clinica_Frba.Menu
{
    public partial class frm_menuPrincipal : Form
    {
        //public Usuario temporalUsuarioHastaQueAndresAgreugueSesion;
        public sesion sesionActual=new sesion();
        public frm_menuPrincipal()
        {
            InitializeComponent();
            new Clinica_Frba.Login.frmLogin(this).Show();
            //this.Visible = false;
            this.Hide();
        }

        
        private void Menu_Load(object sender, EventArgs e)
        {
            this.defaultInvisibility();
        }

        public void defaultInvisibility()
        {

            //Por seguridad, por defecto todos los botones son invisibles
            btn_f5_cancelarAtencion.Visible = false;
            btn_f6_registrarAgenda.Visible = false;
            btn_f7_pedirTurno.Visible = false;
            btn_f8_regLlegada.Visible = false;
            btn_f9_regResultado.Visible = false;
            btn_f10_generarReceta.Visible = false;
            btn_f11_generarEstadisticas.Visible = false;
            btn_f12_comprarBono.Visible = false;

            btn_f13_altaAfiliado.Visible = false;
            btn_f14_bajaAfiliado.Visible = false;
            btn_f15_modificarAfiliado.Visible = false;

            btn_f16_altaProfesional.Visible = false;
            btn_f17_bajaProfesional.Visible = false;
            btn_f18_modificarProfesional.Visible = false;

            btn_f19_altaRol.Visible = false;
            btn_f20_bajaRol.Visible = false;
            btn_f21_modificarRol.Visible = false;

            btn_f22_altaPlan.Visible = false;
            btn_f23_bajaPlan.Visible = false;
            btn_f24_modificarPlan.Visible = false;

            pnlDer.Visible = false;
            pnlIzq.Visible = false;
            lblBienvenida.Visible = false;

            //Array de funcionalidades: false = NO, true = SI
            bool[] funcionalidades;
            funcionalidades = new bool[12];

            //Esto es solo para inicializar un array de prueba
            //for (int i=0; i<=11; i++) funcionalidades[i] = true;

            //Se invoca a la función que determinará que botones mostrar
            //en base al vector de funcionalidades
            // muestraBotones(funcionalidades);

        }

        //La función muestraBotones recibe 
        public void muestraBotones(bool[] funcionalidades)
        {

            //Segun el array de funcionalidades, se mostraran o no los botones.
            if (funcionalidades[0] == true)
            { //ABM afiliado
                btn_f13_altaAfiliado.Visible = true;
                btn_f14_bajaAfiliado.Visible = true;
                btn_f15_modificarAfiliado.Visible = true;
            }
            if (funcionalidades[1] == true)
            { //ABM profesional
                btn_f16_altaProfesional.Visible = true;
                btn_f17_bajaProfesional.Visible = true;
                btn_f18_modificarProfesional.Visible = true;
            }

            if (funcionalidades[2] == true)
            { //ABM especialidad
                btn_f19_altaRol.Visible = true;
                btn_f20_bajaRol.Visible = true;
                btn_f21_modificarRol.Visible = true;
            }

            if (funcionalidades[3] == true)
            { //ABM plan
                btn_f22_altaPlan.Visible = true;
                btn_f23_bajaPlan.Visible = true;
                btn_f24_modificarPlan.Visible = true;
            }

            if (funcionalidades[4] == true) { btn_f5_cancelarAtencion.Visible = true; lbl_ABMs.Visible = false; }
            if (funcionalidades[5] == true) btn_f6_registrarAgenda.Visible = true;
            if (funcionalidades[6] == true) btn_f7_pedirTurno.Visible = true;
            if (funcionalidades[7] == true) btn_f8_regLlegada.Visible = true;
            if (funcionalidades[8] == true) btn_f9_regResultado.Visible = true;
            if (funcionalidades[9] == true) btn_f10_generarReceta.Visible = true;
            if (funcionalidades[10] == true) btn_f11_generarEstadisticas.Visible = true;
            if (funcionalidades[11] == true) btn_f12_comprarBono.Visible = true;
        }

        public void ordenarBotones(sesion sesionLogeo)
        {
            sesionActual = sesionLogeo;
            if (sesionActual.rol.rol_nombre.ToUpper() == "ADMINISTRADOR") //ADMINISTRADOR
            {
                btn_f6_registrarAgenda.Location = new Point(16, 99);
                btn_f8_regLlegada.Location = new Point(16, 156);
                btn_f11_generarEstadisticas.Location = new Point(16, 214);
                btn_f12_comprarBono.Location = new Point(16, 268);
                pnlIzq.Visible = true;
                pnlDer.Visible = true;
                pnlIzq.Location = new Point(11, 89);
                pnlIzq.Height = 229;
                pnlIzq.Width = 179;
                lbl_menuPrincipal.Location = new Point(300, -1);
                this.Height = 360;
                this.Width = 876;
 
            }

            if (sesionActual.rol.rol_nombre.ToUpper() == "PROFESIONAL") //PROFESIONAL
            {

                btn_f5_cancelarAtencion.Location = new Point(112, 101);
                btn_f9_regResultado.Location = new Point(112, 158);
                btn_f10_generarReceta.Location = new Point(112, 216);
                lbl_menuPrincipal.Location = new Point(28, -1);
                pnlIzq.Visible = true;
                pnlIzq.Location = new Point(104, 89);
                pnlIzq.Width = 179;
                pnlIzq.Height = 179;
                this.Height = 328;
                this.Width = 399;
            }

            if (sesionActual.rol.rol_nombre.ToUpper() == "AFILIADO") //AFILIADO
            {
                btn_f5_cancelarAtencion.Location = new Point(112, 101);
                btn_f7_pedirTurno.Location = new Point(112, 158);
                btn_f12_comprarBono.Location = new Point(112, 216);
                lbl_menuPrincipal.Location = new Point(28, -1);
                pnlIzq.Visible = true;
                pnlIzq.Location = new Point(104, 89);
                pnlIzq.Width = 179;
                pnlIzq.Height = 179;
                this.Height = 328;
                this.Width = 399;
            }
            lblBienvenida.Text = sesionActual.WelcomeMessage;
            lblBienvenida.Visible = true;
            this.CenterToScreen();
        }

        private void btn_f13_altaAfiliado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod().Show();
        }

        private void btn_f19_altaRol_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Rol.frmRolAltaMod().Show();
        }

        private void btn_f21_modificarRol_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Rol.frmListadoRoles(1).Show();
        }

        private void btn_f20_bajaRol_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Rol.frmListadoRoles(2).Show();
        }

        private void btn_f16_altaProfesional_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Profesional_Alta.frm_ABMpro_Alta().Show();
        }

        private void btn_f14_bajaAfiliado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoListado().Show();
        }

        private void btn_f15_modificarAfiliado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoListado().Show();
        }

        private void frm_menuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de que deseas salir?", "Cerrar Sesión", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                new Clinica_Frba.Login.frmLogin(this).Refresh();
                new Clinica_Frba.Login.frmLogin(this).Show();
                //this.Visible = false;
                this.Hide();
            }
        }

        private void btn_f12_comprarBono_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Compra_de_Bono.frmCompraBonos(sesionActual.usuario).Show();
        }

        private void btn_f17_bajaProfesional_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Profesional_Listado.frm_ABMpro_listado().Show();  
        }

        private void btn_f18_modificarProfesional_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Profesional_Listado.frm_ABMpro_listado().Show();
        }

        private void btn_f6_registrarAgenda_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Registrar_Agenda.frmRegistrarAgenda().Show();
        }

        private void btn_f8_regLlegada_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Registro_de_LLegada.frmListadoTurnos().Show();
        }

        private void btn_f9_regResultado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Registro_Resultado_Atencion.frmListadoConsultas(sesionActual.usuario.getProfesional()).Show();

        }

        private void btn_f7_pedirTurno_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Pedir_Turno.frmSolicitarTurno(sesionActual.usuario.getAfiliado()).Show();
        }

        private void btn_f5_cancelarAtencion_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Cancelar_Atencion.frmCancelarTurno(sesionActual.usuario.getAfiliado()).Show();
        }



    }
}

