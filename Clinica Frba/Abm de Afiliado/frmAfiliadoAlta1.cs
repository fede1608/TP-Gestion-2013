using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializa los posibles dias
            for (int f = 0; f <= 31; f++)
            {
                cbo_ABMAfiliado_Alta_nacdia.Items.Add(f.ToString());
            }
            cbo_ABMAfiliado_Alta_nacdia.SelectedIndex = 0;
        }

        private void cbo_ABMAfiliado_Alta_nacdia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
