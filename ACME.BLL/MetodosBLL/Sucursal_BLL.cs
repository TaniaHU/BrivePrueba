using ACME.BOL.Modelos;
using ACME.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BLL.MetodosBLL
{
    public class Sucursal_BLL
    {
        private Sucursal_DB _objDB;
        public Sucursal_BLL()
        {
            _objDB = new Sucursal_DB();
        }
        public Sucursal GetSucursalId(int id)
        {
            return _objDB.GetSucursalId(id);
        }
        public List<Sucursal> GetListSucursal()
        {
            return _objDB.GetListSucursal();
        }
        public int Agrega(Sucursal _Item)
        {
            return _objDB.Agrega(_Item);
        }
        public void Actualiza(Sucursal _Item)
        {
            _objDB.Actualiza(_Item);
        }
        public void Borrar(int id)
        {
            _objDB.Borrar(id);
        }
    }
}
