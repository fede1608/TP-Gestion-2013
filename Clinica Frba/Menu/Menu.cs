using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void Menu_Load(object sender, EventArgs e)
        {

            //Por seguridad, por defecto todos los botones son invisibles
            btn_f1_abmAfililiado.Visible = false;
            btn_f2_abmProfesional.Visible = false;
            btn_f3_abmEspecialidad.Visible = false;
            btn_f4_abmPlan.Visible = false;
            btn_f5_cancelarAtencion.Visible = false;
            btn_f6_registrarAgenda.Visible = false;
            btn_f7_pedirTurno.Visible = false;
            btn_f8_regLlegada.Visible = false;
            btn_f9_regResultado.Visible = false;
            btn_f10_generarReceta.Visible = false;
            btn_f11_generarEstadisticas.Visible = false;
            btn_f12_comprarBono.Visible = false;


            //Array de funcionalidades: false = NO, true = SI
            bool[] funcionalidades;
            funcionalidades = new bool[12];
            
            //Esto es solo para inicializar un array de prueba
            for (int i=0; i<=11; i++) funcionalidades[i] = true;

            //Se invoca a la función que determinará que botones mostrar
            //en base al vector de funcionalidades
            muestraBotones(funcionalidades);

            }
        
        //La función muestraBotones recibe 
        private void muestraBotones (bool[] funcionalidades)
        {

            //Segun el array de funcionalidades, se mostraran o no los botones.
            if (funcionalidades[0] == true) btn_f1_abmAfililiado.Visible = true;
            if (funcionalidades[1] == true) btn_f2_abmProfesional.Visible = true;
            if (funcionalidades[2] == true) btn_f3_abmEspecialidad.Visible = true;
            if (funcionalidades[3] == true) btn_f4_abmPlan.Visible = true;
            if (funcionalidades[4] == true) btn_f5_cancelarAtencion.Visible = true;
            if (funcionalidades[5] == true) btn_f6_registrarAgenda.Visible = true;
            if (funcionalidades[6] == true) btn_f7_pedirTurno.Visible = true;
            if (funcionalidades[7] == true) btn_f8_regLlegada.Visible = true;
            if (funcionalidades[8] == true) btn_f9_regResultado.Visible = true;
            if (funcionalidades[9] == true) btn_f10_generarReceta.Visible = true;
            if (funcionalidades[10] == true) btn_f11_generarEstadisticas.Visible = true;
            if (funcionalidades[11] == true) btn_f12_comprarBono.Visible = true;

        }


        }
    }
}
