using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Clinica_Frba.Login;


namespace Clinica_Frba
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();
            //bldr.DataSource = "localhost\\SQLSERVER2008";
            //bldr.InitialCatalog = "GD2C2013";
            //bldr.UserID = "gd";
            //bldr.Password = "gd2013";
            //SqlConnection con = new SqlConnection(bldr.ConnectionString);
            //con.Open();
            ////Form1.textBox2.text = ("Connection String: " + con.ConnectionString);
            //Console.WriteLine("Database: " + con.Database);
            //Console.WriteLine("Data Source: " + con.DataSource);
            //con.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Clinica_Frba.Menu.frm_menuPrincipal());
        }
    }
}
