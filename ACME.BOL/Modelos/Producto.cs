using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACME.BOL.Modelos
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int CodigoBarras { get; set; }
        public int Cantidad { get; set; }
        public bool PrecioUnitario { get; set; }
        public int SucursalId { get; set; }
    }
}
