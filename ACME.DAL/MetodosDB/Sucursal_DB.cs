using ACME.BOL.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACME.DAL
{
    public class Sucursal_DB
    {
        private BaseDatosContext _context;
        public Sucursal_DB()
        {
            _context = new BaseDatosContext();
        }

        public Sucursal GetSucursalId(int id)
        {
            return _context.Sucursal.Where(a => a.SucursalId == id).FirstOrDefault();
        }
        public List<Sucursal> GetListSucursal()
        {
            return _context.Sucursal.ToList();
        }
        public int Agrega(Sucursal _Item)
        {
            _context.Sucursal.Add(_Item);
            _context.SaveChanges();
            return _Item.SucursalId;
        }
        public void Actualiza(Sucursal _Item)
        {
            _context.Entry(_Item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Borrar(int id)
        {
            Sucursal _Item = _context.Sucursal.Find(id);
            _context.Sucursal.Remove(_Item);
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
