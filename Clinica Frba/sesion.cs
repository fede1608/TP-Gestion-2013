using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba
{
    class sesion
    {
        private static string ConnectionString 
        { 
            get { return Properties.Settings.Default.GD2C2013ConnectionString; 
            } 
        }
    }
}
