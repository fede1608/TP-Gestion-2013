using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Sql;

namespace Clinica_Frba
{
    public partial class Form1 : Form
    {
        public int cont = 0;
        public SqlDataReader myReader = null;
        public Form1()
        {
            InitializeComponent();
            callCon();
        }

        private void callCon()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLSERVER2008;Initial Catalog=GD2C2013;User ID=gd;Password=gd2013");

            con.Open();
            
            SqlCommand myCommand = new SqlCommand("SELECT top 100  * from GD2C2013.gd_esquema.Maestra",
                                                     con);
            myReader = myCommand.ExecuteReader();
            //while (myReader.Read())
            //{
            //    this.textBox1.Text = (myReader[0].ToString());
            //    this.textBox2.Text = (myReader[1].ToString());
            //}
            //con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myReader.Read())
            {
                this.textBox1.Text = (myReader[0].ToString());
                this.textBox2.Text = (myReader[1].ToString());
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formL= new NewFolder10.frmLogin();
            formL.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
