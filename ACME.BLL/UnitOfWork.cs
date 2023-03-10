
using ACME.BLL.MetodosBLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BLL
{
    public class UnitOfWork
    {
        public Producto_BLL producto;
        public Sucursal_BLL sucursal;
        public UnitOfWork()
        {
            producto = new Producto_BLL();
            sucursal = new Sucursal_BLL();
        }
    }
}
