﻿using System;
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
            btn_f13_altaAfiliado.Visible = false;
            btn_f14_bajaAfiliado.Visible = false;
            btn_f15_modificarAfiliado.Visible = false;

            btn_f16_altaProfesional.Visible = false;
            btn_f17_bajaProfesional.Visible = false;
            btn_f18_modificarProfesional.Visible = false;

            btn_f19_altaEspecialidad.Visible = false;
            btn_f20_bajaEspecialidad.Visible = false;
            btn_f21_modificarEspecialidad.Visible = false;

            btn_f22_altaPlan.Visible = false;
            btn_f23_bajaPlan.Visible = false;
            btn_f24_modificarPlan.Visible = false;

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
            if (funcionalidades[0] == true) { //ABM afiliado
                btn_f13_altaAfiliado.Visible = true;
                btn_f14_bajaAfiliado.Visible = true;
                btn_f15_modificarAfiliado.Visible = true;
                }
            if (funcionalidades[1] == true) { //ABM profesional
                btn_f16_altaProfesional.Visible = true;
                btn_f17_bajaProfesional.Visible = true;
                btn_f18_modificarProfesional.Visible = true;
                }

            if (funcionalidades[2] == true) { //ABM especialidad
                btn_f19_altaEspecialidad.Visible = true;
                btn_f20_bajaEspecialidad.Visible = true;
                btn_f21_modificarEspecialidad.Visible = true;
                }

            if (funcionalidades[3] == true) { //ABM plan
                btn_f22_altaPlan.Visible = true;
                btn_f23_bajaPlan.Visible = true;
                btn_f24_modificarPlan.Visible = true;
                }

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
