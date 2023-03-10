using ACME.BOL.Modelos;
using ACME.BOL.ModelosSistema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACME.DAL.MetodosDB
{
    public class Producto_DB
    {

        private BaseDatosContext _context;
        public Producto_DB()
        {
            _context = new BaseDatosContext();
        }

        public Producto GetProductoId(int id)
        {
            return _context.Producto.Where(a => a.ProductoId == id).FirstOrDefault();
        }
        public List<Producto> GetListProducto()
        {
            return _context.Producto.ToList();
        }
        public List<ProductoViewModel> GetVMListProducto(int id)
        {
            var categoria = (from p in _context.Producto
                             join s in _context.Sucursal on p.SucursalId equals s.SucursalId
                             where id == s.SucursalId
                             select new ProductoViewModel
                             {
                              ProductoId = p.ProductoId,
                              Cantidad = p.Cantidad,
                              CodigoBarras = p.CodigoBarras,
                              Nombre = p.Nombre,
                              NomSucursal = s.Nombre,
                              PrecioUnitario = p.PrecioUnitario,
                              SucursalId = p.SucursalId
                             }).ToList();
            return categoria;
        }

        public int Agrega(Producto _Item)
        {
            _context.Producto.Add(_Item);
            _context.SaveChanges();
            return _Item.ProductoId;
        }
        public void Actualiza(Producto _Item)
        {
            _context.Entry(_Item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Borrar(int id)
        {
            Producto _Item = _context.Producto.Find(id);
            _context.Producto.Remove(_Item);
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
