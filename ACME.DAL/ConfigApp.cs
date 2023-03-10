using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.DAL
{
    public class ConfigApp
    {
        public string NombreBD = "ACME";
        public string CadenaServidor;


        public ConfigApp()
        {
            CadenaServidor = $"data source=localhost; initial catalog = {NombreBD}; persist security info = True; Integrated Security = SSPI; ";
        }
    }
}
