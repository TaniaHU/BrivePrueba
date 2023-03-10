using ACME.BOL.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.DAL
{
    public partial class BaseDatosContext : DbContext
    {
        #region Tablas
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigApp app = new ConfigApp();
            optionsBuilder.UseSqlServer(app.CadenaServidor);
        }
    }
}
