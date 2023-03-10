using ACME.BOL.Modelos;
using ACME.BOL.ModelosSistema;
using ACME.DAL.MetodosDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BLL.MetodosBLL
{
    public class Producto_BLL
    {
        private Producto_DB _objDB;
        public Producto_BLL()
        {
            _objDB = new Producto_DB();
        }
        public Producto GetProductoId(int id)
        {
            return _objDB.GetProductoId(id);
        }
        public List<Producto> GetListProducto()
        {
            return _objDB.GetListProducto();
        }
        public List<ProductoViewModel> GetVMListProducto(int id)
        {
            return _objDB.GetVMListProducto(id); // dar F12 sobre GetVMListProducto
        }
            public int Agrega(Producto _Item)
        {
            return _objDB.Agrega(_Item);
        }
        public void Actualiza(Producto _Item)
        {
            _objDB.Actualiza(_Item);
        }
        public void Borrar(int id)
        {
            _objDB.Borrar(id);
        }
    }
}
