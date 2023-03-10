using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACME.BOL.Modelos
{
    public class Sucursal
    {
        [Key]
        public int SucursalId { get; set; }
        public string Nombre { get; set; }
    }
}
