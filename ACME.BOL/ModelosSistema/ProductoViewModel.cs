using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACME.BOL.ModelosSistema
{
    public class ProductoViewModel
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string CodigoBarras { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public int SucursalId { get; set; }
        public string NomSucursal { get; set; }
        public bool Activo { get; set; }

    }
}
