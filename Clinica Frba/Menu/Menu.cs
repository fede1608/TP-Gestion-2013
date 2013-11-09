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
using Clinica_Frba.Sql;

namespace Clinica_Frba.Menu
{
    public partial class frm_menuPrincipal : Form
    {
        //public Usuario temporalUsuarioHastaQueAndresAgreugueSesion;
        public sesion sesionActual = new sesion();
        public List<string> listaAux = new List<string>();



        public frm_menuPrincipal()
        {
            InitializeComponent();
            new Clinica_Frba.Login.frmLogin(this).Show();
            //this.Visible = false;
            this.Hide();

        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        public void ordenarBotones(sesion sesionLogeo)
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            sesionActual = sesionLogeo;


            var result2 = runner.Select("SELECT func_id,func_descripcion FROM SIGKILL.funcionalidad inner join SIGKILL.func_rol on(func_id=frol_funcionalidad) Where frol_rol={0}", sesionActual.rol.rol_id);
            var lista = new Adapter().TransformMany<Funcionalidad>(result2);


            #region //CREACION DINÁMICA DE BOTONES
            // posicion inicial de la primera etiqueta en el formulario (depende de tu diseño)
            int baseX = 40;
            int baseY = 100;
            int suma = 160;

            //bntCerrar
            System.Windows.Forms.Button btnCerrarSesion = new System.Windows.Forms.Button();
            btnCerrarSesion.BackColor = System.Drawing.Color.Red;
            //btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnCerrarSesion.Location = new System.Drawing.Point(baseX, 75);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new System.Drawing.Size(90, 23);
            btnCerrarSesion.TabIndex = 29;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            this.Controls.Add(btnCerrarSesion);

            btnCerrarSesion.Click += new EventHandler(btnCerrarSesion_Click);

            //Se pasa el Data Table a una lista auxiliar de strings
            for (int f = 0; f < lista.Count; f++)
            {
                listaAux.Add(lista[f].func_descripcion);

            }


            System.Windows.Forms.Label lbl_ABMs = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl_menuPrincipal = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblBienvenida = new System.Windows.Forms.Label();

            // lblABM
            lbl_ABMs.AutoSize = true;
            lbl_ABMs.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_ABMs.Location = new System.Drawing.Point(330, 100);
            lbl_ABMs.Name = "lbl_ABMs";
            lbl_ABMs.Size = new System.Drawing.Size(321, 27);
            lbl_ABMs.TabIndex = 43;
            lbl_ABMs.Text = "Altas, bajas y modificaciones";
            lbl_ABMs.Visible = false;

            //lblMenuPrincipal
            lbl_menuPrincipal.AutoSize = true;
            lbl_menuPrincipal.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_menuPrincipal.Location = new System.Drawing.Point(28, -4);
            lbl_menuPrincipal.Name = "lbl_menuPrincipal";
            lbl_menuPrincipal.Size = new System.Drawing.Size(335, 55);
            lbl_menuPrincipal.TabIndex = 11;
            lbl_menuPrincipal.Text = "Menu principal";

            //lblBienvenido
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBienvenida.ForeColor = System.Drawing.Color.RoyalBlue;
            lblBienvenida.Location = new System.Drawing.Point(46, 59);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new System.Drawing.Size(78, 15);
            lblBienvenida.TabIndex = 26;
            lblBienvenida.Text = "Bienvenida";

            this.Controls.Add(lbl_ABMs);
            this.Controls.Add(lbl_menuPrincipal);
            this.Controls.Add(lblBienvenida);



            int tamañoFormX = 0;
            int tamañoFormY = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                //Pregunto si el rol del afiliado esta en la lista 
                if (listaAux.Exists(x => x == "ABM de afiliados"))
                {
                    System.Windows.Forms.Button btn_alta_afiliado = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_baja_afiliado = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_modificar_afiliado = new System.Windows.Forms.Button();

                    btn_alta_afiliado.Location = new Point(baseX + suma, baseY + (39 * 1));
                    btn_alta_afiliado.Text = "Dar de Alta Afiliado";
                    //i++;
                    btn_baja_afiliado.Location = new Point(baseX + suma, baseY + (39 * 2));
                    btn_baja_afiliado.Text = "Dar de Baja Afiliado";
                    //i++;
                    btn_modificar_afiliado.Location = new Point(baseX + suma, baseY + (39 * 3));
                    btn_modificar_afiliado.Text = "Modificar Afiliado";
                    //i++;
                    btn_alta_afiliado.Width = btn_baja_afiliado.Width = btn_modificar_afiliado.Width = 150;
                    btn_alta_afiliado.Height = btn_baja_afiliado.Height = btn_modificar_afiliado.Height = 30;

                    this.Controls.Add(btn_alta_afiliado);
                    this.Controls.Add(btn_baja_afiliado);
                    this.Controls.Add(btn_modificar_afiliado);
                    //lista.RemoveAt(y);



                    btn_alta_afiliado.Click += new EventHandler(btn_alta_afiliado_Click);
                    btn_baja_afiliado.Click += new EventHandler(btn_baja_afiliado_Click);
                    btn_modificar_afiliado.Click += new EventHandler(btn_modificar_afiliado_Click);
                    suma = suma + 150;

                    tamañoFormX = tamañoFormX + baseX + suma;
                    tamañoFormY = tamañoFormY + baseY;

                    btn_alta_afiliado.BackColor = btn_baja_afiliado.BackColor = btn_modificar_afiliado.BackColor = System.Drawing.Color.DodgerBlue;
                    btn_alta_afiliado.Font = btn_baja_afiliado.Font = btn_modificar_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_alta_afiliado.Size = btn_baja_afiliado.Size = btn_modificar_afiliado.Size = new System.Drawing.Size(156, 41);
                    btn_alta_afiliado.TabIndex = btn_baja_afiliado.TabIndex = btn_modificar_afiliado.TabIndex = 9;
                    btn_alta_afiliado.UseVisualStyleBackColor = btn_baja_afiliado.UseVisualStyleBackColor = btn_modificar_afiliado.UseVisualStyleBackColor = false;

                }
                //Pregunto si el rol del afiliado esta en la lista 
                if (listaAux.Exists(x => x == "ABM de profesional"))
                {
                    lbl_ABMs.Visible = true;
                    System.Windows.Forms.Button btn_alta_profesional = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_baja_profesional = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_modificar_profesional = new System.Windows.Forms.Button();

                    btn_alta_profesional.Location = new Point(baseX + suma, baseY + (39 * 1));
                    btn_alta_profesional.Text = "Dar de Alta Profesional";
                    //i++;
                    btn_baja_profesional.Location = new Point(baseX + suma, baseY + (39 * 2));
                    btn_baja_profesional.Text = "Dar de Baja Profesional";
                    //i++;
                    btn_modificar_profesional.Location = new Point(baseX + suma, baseY + (39 * 3));
                    btn_modificar_profesional.Text = "Modificar Profesional";
                    //i++;

                    btn_alta_profesional.Width = btn_baja_profesional.Width = btn_modificar_profesional.Width = 150;
                    btn_alta_profesional.Height = btn_baja_profesional.Height = btn_modificar_profesional.Height = 30;

                    this.Controls.Add(btn_alta_profesional);
                    this.Controls.Add(btn_baja_profesional);
                    this.Controls.Add(btn_modificar_profesional);

                    btn_alta_profesional.Click += new EventHandler(btn_alta_profesional_Click);
                    btn_baja_profesional.Click += new EventHandler(btn_baja_profesional_Click);
                    btn_modificar_profesional.Click += new EventHandler(btn_modificar_profesional_Click);

                    suma = suma + 150;
                    tamañoFormX = tamañoFormX + baseX + suma;
                    btn_alta_profesional.BackColor = btn_baja_profesional.BackColor = btn_modificar_profesional.BackColor = System.Drawing.Color.OrangeRed;
                    btn_alta_profesional.Font = btn_baja_profesional.Font = btn_modificar_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_alta_profesional.Size = btn_baja_profesional.Size = btn_modificar_profesional.Size = new System.Drawing.Size(156, 41);
                    btn_alta_profesional.TabIndex = btn_baja_profesional.TabIndex = btn_modificar_profesional.TabIndex = 12;
                    btn_alta_profesional.UseVisualStyleBackColor = btn_baja_profesional.UseVisualStyleBackColor = btn_modificar_profesional.UseVisualStyleBackColor = false;

                }

                //        //Pregunto si el rol del afiliado esta en la lista 
                if (listaAux.Exists(x => x == "ABM de especialidades médicas"))
                {
                    lbl_ABMs.Visible = true;
                    System.Windows.Forms.Button btn_alta_espmedic = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_baja_espmedic = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_modificar_espmedic = new System.Windows.Forms.Button();

                    btn_alta_espmedic.Location = new Point(baseX + suma, baseY + (39 * 1));
                    btn_alta_espmedic.Text = "Dar de Alta Especialidades Médicas";
                    //i++;
                    btn_baja_espmedic.Location = new Point(baseX + suma, baseY + (39 * 2));
                    btn_baja_espmedic.Text = "Dar de Baja Especialidades Médicas";
                    //i++;
                    btn_modificar_espmedic.Location = new Point(baseX + suma, baseY + (39 * 3));
                    btn_modificar_espmedic.Text = "Modificar Especialidades Médicas";

                    btn_alta_espmedic.Width = btn_baja_espmedic.Width = btn_modificar_espmedic.Width = 150;
                    btn_alta_espmedic.Height = btn_baja_espmedic.Height = btn_modificar_espmedic.Height = 30;
                    //i++;
                    this.Controls.Add(btn_alta_espmedic);
                    this.Controls.Add(btn_baja_espmedic);
                    this.Controls.Add(btn_modificar_espmedic);
                    tamañoFormX = tamañoFormX + baseX + suma;
                    btn_alta_espmedic.Click += new EventHandler(btn_alta_espmedic_Click);
                    btn_baja_espmedic.Click += new EventHandler(btn_baja_espmedic_Click);
                    btn_modificar_espmedic.Click += new EventHandler(btn_modificar_espmedic_Click);
                    suma = suma + 150;

                    btn_alta_espmedic.BackColor = btn_baja_espmedic.BackColor = btn_modificar_espmedic.BackColor = System.Drawing.Color.LimeGreen;
                    btn_alta_espmedic.Font = btn_baja_espmedic.Font = btn_modificar_espmedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_alta_espmedic.Size = btn_baja_espmedic.Size = btn_modificar_espmedic.Size = new System.Drawing.Size(156, 41);
                    btn_alta_espmedic.TabIndex = btn_baja_espmedic.TabIndex = btn_modificar_espmedic.TabIndex = 15;
                    btn_alta_espmedic.UseVisualStyleBackColor = btn_baja_espmedic.UseVisualStyleBackColor = btn_modificar_espmedic.UseVisualStyleBackColor = false;

                }


                if (listaAux.Exists(x => x == "ABM de plan"))
                {
                    lbl_ABMs.Visible = true;
                    System.Windows.Forms.Button btn_alta_plan = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_baja_plan = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_modificar_plan = new System.Windows.Forms.Button();

                    btn_alta_plan.Location = new Point(baseX + suma, baseY + (39 * 1));
                    btn_alta_plan.Text = "Dar de Alta Plan";
                    //i++;
                    btn_baja_plan.Location = new Point(baseX + suma, baseY + (39 * 2));
                    btn_baja_plan.Text = "Dar de Baja Plan";
                    //i++;
                    btn_modificar_plan.Location = new Point(baseX + suma, baseY + (39 * 3));
                    btn_modificar_plan.Text = "Modificar Plan";
                    tamañoFormX = tamañoFormX + baseX + suma;
                    btn_alta_plan.Width = btn_baja_plan.Width = btn_modificar_plan.Width = 150;
                    btn_alta_plan.Height = btn_baja_plan.Height = btn_modificar_plan.Height = 30;
                    //i++;
                    this.Controls.Add(btn_alta_plan);
                    this.Controls.Add(btn_baja_plan);
                    this.Controls.Add(btn_modificar_plan);

                    btn_alta_plan.Click += new EventHandler(btn_alta_plan_Click);
                    btn_baja_plan.Click += new EventHandler(btn_baja_plan_Click);
                    btn_modificar_plan.Click += new EventHandler(btn_modificar_plan_Click);
                    suma = suma + 150;

                    btn_alta_plan.BackColor = btn_baja_plan.BackColor = btn_modificar_plan.BackColor = System.Drawing.Color.Orange;
                    btn_alta_plan.Font = btn_baja_plan.Font = btn_modificar_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_alta_plan.Size = btn_baja_plan.Size = btn_modificar_plan.Size = new System.Drawing.Size(156, 41);
                    btn_alta_plan.TabIndex = btn_baja_plan.TabIndex = btn_modificar_plan.TabIndex = 18;
                    btn_alta_plan.UseVisualStyleBackColor = btn_baja_plan.UseVisualStyleBackColor = btn_modificar_plan.UseVisualStyleBackColor = false;

                }

                if (listaAux.Exists(x => x == "ABM del rol"))
                {
                    lbl_ABMs.Visible = true;
                    System.Windows.Forms.Button btn_alta_rol = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_baja_rol = new System.Windows.Forms.Button();
                    System.Windows.Forms.Button btn_modificar_rol = new System.Windows.Forms.Button();

                    btn_alta_rol.Location = new Point(baseX + suma, baseY + (39 * 1));
                    btn_alta_rol.Text = "Dar de Alta Rol";
                    //i++;
                    btn_baja_rol.Location = new Point(baseX + suma, baseY + (39 * 2));
                    btn_baja_rol.Text = "Dar de Baja Rol";
                    //i++;
                    btn_modificar_rol.Location = new Point(baseX + suma, baseY + (39 * 3));
                    btn_modificar_rol.Text = "Modificar Rol";

                    btn_alta_rol.Width = btn_baja_rol.Width = btn_modificar_rol.Width = 150;
                    btn_alta_rol.Height = btn_baja_rol.Height = btn_modificar_rol.Height = 30;
                    //i++;
                    this.Controls.Add(btn_alta_rol);
                    this.Controls.Add(btn_baja_rol);
                    this.Controls.Add(btn_modificar_rol);

                    btn_alta_rol.Click += new EventHandler(btn_alta_rol_Click);
                    btn_baja_rol.Click += new EventHandler(btn_baja_rol_Click);
                    btn_modificar_rol.Click += new EventHandler(btn_modificar_rol_Click);
                    suma = suma + 150;
                    tamañoFormX = tamañoFormX + baseX + suma;
                    btn_alta_rol.BackColor = btn_baja_rol.BackColor = btn_modificar_rol.BackColor = System.Drawing.Color.CadetBlue;
                    btn_alta_rol.Font = btn_baja_rol.Font = btn_modificar_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_alta_rol.Size = btn_baja_rol.Size = btn_modificar_rol.Size = new System.Drawing.Size(156, 41);
                    btn_alta_rol.TabIndex = btn_baja_rol.TabIndex = btn_modificar_rol.TabIndex = 15;
                    btn_alta_rol.UseVisualStyleBackColor = btn_baja_rol.UseVisualStyleBackColor = btn_modificar_rol.UseVisualStyleBackColor = false;

                }

                if (listaAux.Exists(x => x == "Compra de bonos"))
                {
                    System.Windows.Forms.Button btn_compra_bonos = new System.Windows.Forms.Button();
                    btn_compra_bonos.Location = new Point(baseX, baseY + (29 * i));
                    btn_compra_bonos.Text = "Comprar Bono";
                    i++;

                    btn_compra_bonos.Width = 150;
                    btn_compra_bonos.Height = 30;

                    this.Controls.Add(btn_compra_bonos);

                    btn_compra_bonos.Click += new EventHandler(btn_compra_bonos_Click);


                }
                if (listaAux.Exists(x => x == "Venta de bonos en ventanilla"))
                {
                    System.Windows.Forms.Button btn_venta_bonos_ventanilla = new System.Windows.Forms.Button();
                    btn_venta_bonos_ventanilla.Location = new Point(baseX, baseY + (29 * i));
                    btn_venta_bonos_ventanilla.Text = "Venta bonos en ventanilla";
                    i++;

                    btn_venta_bonos_ventanilla.Width = 150;
                    btn_venta_bonos_ventanilla.Height = 30;

                    this.Controls.Add(btn_venta_bonos_ventanilla);

                    tamañoFormY = tamañoFormY + baseY;

                    btn_venta_bonos_ventanilla.Click += new EventHandler(btn_venta_bonos_ventanilla_Click);
                }

                if (listaAux.Exists(x => x == "Pedir un turno"))
                {
                    System.Windows.Forms.Button btn_pedir_turno = new System.Windows.Forms.Button();
                    btn_pedir_turno.Location = new Point(baseX, baseY + (29 * i));
                    btn_pedir_turno.Text = "Pedir un turno";
                    i++;

                    btn_pedir_turno.Width = 150;
                    btn_pedir_turno.Height = 30;

                    this.Controls.Add(btn_pedir_turno);

                    btn_pedir_turno.Click += new EventHandler(btn_pedir_turno_Click);
                    tamañoFormY = tamañoFormY + baseY;
                }

                if (listaAux.Exists(x => x == "Registrar llegada para atención médica"))
                {
                    System.Windows.Forms.Button btn_registrar_llegada = new System.Windows.Forms.Button();
                    btn_registrar_llegada.Location = new Point(baseX, baseY + (29 * i));
                    btn_registrar_llegada.Text = "Registrar Llegada";
                    i++;

                    btn_registrar_llegada.Width = 150;
                    btn_registrar_llegada.Height = 30;

                    this.Controls.Add(btn_registrar_llegada);
                    tamañoFormY = tamañoFormY + baseY;
                    btn_registrar_llegada.Click += new EventHandler(btn_registrar_llegada_Click);
                }

                if (listaAux.Exists(x => x == "Registrar resultado de atención médica"))
                {
                    System.Windows.Forms.Button btn_registrar_resultado = new System.Windows.Forms.Button();
                    btn_registrar_resultado.Location = new Point(baseX, baseY + (29 * i));
                    btn_registrar_resultado.Text = "Registrar Diagnóstico";
                    i++;

                    btn_registrar_resultado.Width = 150;
                    btn_registrar_resultado.Height = 30;

                    this.Controls.Add(btn_registrar_resultado);
                    tamañoFormY = tamañoFormY + baseY;
                    btn_registrar_resultado.Click += new EventHandler(btn_registrar_resultado_Click);
                }

                if (listaAux.Exists(x => x == "Cancelar una atención médica"))
                {
                    System.Windows.Forms.Button btn_cancelar_atencion = new System.Windows.Forms.Button();
                    btn_cancelar_atencion.Location = new Point(baseX, baseY + (29 * i));
                    btn_cancelar_atencion.Text = "Cancelar atención médica";
                    i++;

                    btn_cancelar_atencion.Width = 150;
                    btn_cancelar_atencion.Height = 30;

                    this.Controls.Add(btn_cancelar_atencion);
                    tamañoFormY = tamañoFormY + baseY;
                    btn_cancelar_atencion.Click += new EventHandler(btn_cancelar_atencion_Click);
                }

                if (listaAux.Exists(x => x == "Generar una receta médica"))
                {
                    System.Windows.Forms.Button btn_generar_receta = new System.Windows.Forms.Button();
                    btn_generar_receta.Location = new Point(baseX, baseY + (29 * i));
                    btn_generar_receta.Text = "Generar receta médica";
                    i++;

                    btn_generar_receta.Width = 150;
                    btn_generar_receta.Height = 30;

                    this.Controls.Add(btn_generar_receta);
                    tamañoFormY = tamañoFormY + baseY;
                    btn_generar_receta.Click += new EventHandler(btn_generar_receta_Click);
                }
                if (listaAux.Exists(x => x == "Generar un listado estadístico"))
                {
                    System.Windows.Forms.Button btn_generar_estadisticas = new System.Windows.Forms.Button();
                    btn_generar_estadisticas.Location = new Point(baseX, baseY + (29 * i));
                    btn_generar_estadisticas.Text = "Generar Estadísticas";
                    i++;
                    tamañoFormY = tamañoFormY + baseY;
                    btn_generar_estadisticas.Width = 150;
                    btn_generar_estadisticas.Height = 30;

                    this.Controls.Add(btn_generar_estadisticas);

                    btn_generar_estadisticas.Click += new EventHandler(btn_generar_estadisticas_Click);
                }
                if (listaAux.Exists(x => x == "Registrar agenda de profesional"))
                {
                    System.Windows.Forms.Button btn_agenda_profesional = new System.Windows.Forms.Button();
                    btn_agenda_profesional.Location = new Point(baseX, baseY + (29 * i));
                    btn_agenda_profesional.Text = "Agenda Profesional";
                    i++;
                    tamañoFormY = tamañoFormY + baseY;
                    btn_agenda_profesional.Width = 150;
                    btn_agenda_profesional.Height = 30;

                    this.Controls.Add(btn_agenda_profesional);

                    btn_agenda_profesional.Click += new EventHandler(btn_agenda_profesional_Click);
                }
                if (listaAux.Exists(x => x == "Ver Agenda"))
                {
                    System.Windows.Forms.Button btn_ver_agenda = new System.Windows.Forms.Button();
                    btn_ver_agenda.Location = new Point(baseX, baseY + (29 * i));
                    btn_ver_agenda.Text = "Ver Agenda Profesional";
                    i++;

                    tamañoFormY = tamañoFormY + baseY;
                    btn_ver_agenda.Width = 150;
                    btn_ver_agenda.Height = 30;

                    this.Controls.Add(btn_ver_agenda);
                    tamañoFormY = tamañoFormY + baseY;
                    btn_ver_agenda.Click += new EventHandler(btn_ver_agenda_Click);
                }
                tamañoFormY = baseY + (45 * i);
                i = i + 12;


            }
            lblBienvenida.Visible = true;
            lblBienvenida.Text = sesionLogeo.WelcomeMessage;
            lista.Clear();

            #endregion

            if (tamañoFormX == 0)
            {
                this.Width = 400;

            }
            else
            {
                this.Width = tamañoFormX + 200;

            }
            this.Height = tamañoFormY + 100;


            this.CenterToScreen();

        }



        #region //EVENTOS DE LOS BOTONES
        //Eventos click de los botones ABM afiliado
        private void btn_alta_afiliado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod(true, 0, false).Show();
        }

        private void btn_baja_afiliado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoListado(false).Show();
        }

        private void btn_modificar_afiliado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoListado(true).Show();
        }

        //Eventos click de los botones ABM Profesional
        private void btn_alta_profesional_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Profesional_Alta.frm_ABMpro_Alta().Show();
        }

        private void btn_baja_profesional_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Profesional_Listado.frm_ABMpro_listado().Show();
        }

        private void btn_modificar_profesional_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Profesional_Listado.frm_ABMpro_listado().Show();
        }

        //Eventos click de los botones ABM Esp. Medicas
        private void btn_alta_espmedic_Click(object sender, EventArgs e)
        {
            //   new Clinica_Frba.Abm_de_profesional.frmAfiliadoAltaMod().Show();
        }

        private void btn_baja_espmedic_Click(object sender, EventArgs e)
        {
            // new Clinica_Frba.Abm_de_Profesional.frmAfiliadoListado().Show();
        }

        private void btn_modificar_espmedic_Click(object sender, EventArgs e)
        {
            //new Clinica_Frba.Abm_de_Profesional.frmAfiliadoAltaMod().Show();
        }

        //Eventos click de los botones ABM Plan
        private void btn_alta_plan_Click(object sender, EventArgs e)
        {
            //new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod().Show();
        }

        private void btn_baja_plan_Click(object sender, EventArgs e)
        {
            //new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoListado().Show();
        }

        private void btn_modificar_plan_Click(object sender, EventArgs e)
        {
            //new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod().Show();
        }


        //Eventos click de los botones ABM Rol
        private void btn_alta_rol_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Rol.frmRolAltaMod().Show();
        }

        private void btn_baja_rol_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Rol.frmListadoRoles(2).Show();
        }

        private void btn_modificar_rol_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Rol.frmListadoRoles(1).Show();
        }


        // Evento click comprar bonos
        private void btn_compra_bonos_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Compra_de_Bono.frmCompraBonos(sesionActual.usuario).Show();
        }

        // Evento click Venta de bonos en ventanilla
        private void btn_venta_bonos_ventanilla_Click(object sender, EventArgs e)
        {
            //new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod().Show();
        }

        private void btn_pedir_turno_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Pedir_Turno.frmSolicitarTurno(sesionActual.usuario.getAfiliado()).Show();
        }


        //Evento click de registrar llegada
        private void btn_registrar_llegada_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Registro_de_LLegada.frmListadoTurnos().Show();
        }

        //Evento click de registrar resultado
        private void btn_registrar_resultado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Registro_Resultado_Atencion.frmListadoConsultas(sesionActual.usuario.getProfesional()).Show();
        }

        //Evento click de cancelar atencion
        private void btn_cancelar_atencion_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Cancelar_Atencion.frmCancelarTurno(sesionActual.usuario.getProfesional()).Show();
        }

        //Evento click de generar receta
        private void btn_generar_receta_Click(object sender, EventArgs e)
        {
            //new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod().Show();
        }

        //Evento click de generar estadisticas
        private void btn_generar_estadisticas_Click(object sender, EventArgs e)
        {
            //new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod().Show();
        }

        //Evento click de agenda profesional
        private void btn_agenda_profesional_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Registrar_Agenda.frmRegistrarAgenda().Show();
        }


        //Evento click de ver agenda
        private void btn_ver_agenda_Click(object sender, EventArgs e)
        {
            //new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod().Show();
        }

        #endregion

        private void frm_menuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de que deseas Salir?", "Cerrar Sesión", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //ESTO BORRA ABSOLUTAMENTE TODOS LOS CONTROLES
                while (this.Controls.Count > 1)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item != btnCerrarSesion)
                        {
                            this.Controls.Remove(item);
                            continue;
                        }
 
                    }
                }

            }
            listaAux.Clear();

            new Clinica_Frba.Login.frmLogin(this).Refresh();
            new Clinica_Frba.Login.frmLogin(this).Show();

            this.Hide();
        }
    }
}
