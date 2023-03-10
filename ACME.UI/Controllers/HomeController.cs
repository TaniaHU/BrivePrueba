using ACME.BLL;
using ACME.BOL.Modelos;
using ACME.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

// La cadena de conexion se encuentra en ACME.Dal/ConfigApp.cs
// Las clases se encuentran en ACME.BOL/Modelos

namespace ACME.UI.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork _unit;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _unit = new UnitOfWork();
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        #region Sucursal
        // Vista con listado de sucursales 
        public IActionResult Sucursales()
        {
            return View(_unit.sucursal.GetListSucursal());
        }

        // Abre modal para agregar o editar una sucursal
        public IActionResult AgregaSucursal(int? id)
        {
            Sucursal sucursal = _unit.sucursal.GetSucursalId(id.Value);
            return PartialView(sucursal);
        }

        // Metodo para guardar sucursal nueva o edicion de sucursal en bd
        [HttpPost]
        public async Task<JsonResult> AgregaSucursal(Sucursal modeloSucursal)
        {
            if (modeloSucursal.SucursalId == 0)
            {
                Sucursal sucursal = new Sucursal
                {
                    Nombre = modeloSucursal.Nombre,
                    SucursalId = modeloSucursal.SucursalId,
                };

                _unit.sucursal.Agrega(sucursal);

                var SalidaOk = new
                {
                    isSuccess = true,
                    sucursal,
                    mensaje = ModelState
                };
                return Json(SalidaOk);
            }
            else
            {
                Sucursal sucursal = new Sucursal
                {
                    Nombre = modeloSucursal.Nombre,
                    SucursalId = modeloSucursal.SucursalId
                };

                _unit.sucursal.Actualiza(sucursal);

                var SalidaOk = new
                {
                    isSuccess = true,
                    sucursal,
                    mensaje = ModelState
                };
                return Json(SalidaOk);
            }
        }

        //Metodo para borrar sucursal
        [HttpPost]
        public async Task<JsonResult> Borrar(int Id)
        {
            _unit.sucursal.Borrar(Id);
            return Json(true);
        }
        #endregion

        #region Producto
        // Listado de productos por sucursalId
        public IActionResult Productos(int id)
        {
            return View(_unit.producto.GetVMListProducto(id)); // dar F12 sobre .GetVMListProducto o ir a ACME.BLL/MetodosBLL/Producto_BLL.cs para visualizar linq de consulta
        }

        //Abre modal agregar un producto o editar un producto
        public IActionResult AgregaProducto(int? id)
        {
            ViewData["Sucursal"] = new SelectList(_unit.sucursal.GetListSucursal(), "SucursalId", "Nombre");
            Producto producto = _unit.producto.GetProductoId(id.Value);
            return PartialView(producto);
        }

        //Metodo para agregar un producto o editar un producto en bd
        [HttpPost]
        public async Task<JsonResult> AgregaProducto(Producto modeloProducto)
        {
            if (modeloProducto.ProductoId == 0)
            {
                Producto producto = new Producto
                {
                    ProductoId = modeloProducto.ProductoId,
                    Cantidad = modeloProducto.Cantidad,
                    CodigoBarras = modeloProducto.CodigoBarras,
                    Nombre = modeloProducto.Nombre,
                    PrecioUnitario = modeloProducto.PrecioUnitario,
                    SucursalId = modeloProducto.SucursalId
                };
                _unit.producto.Agrega(producto);

                var SalidaOk = new
                {
                    isSuccess = true,
                    producto,
                    mensaje = ModelState
                };
                return Json(SalidaOk);
            }
            else
            {
                Producto producto = new Producto
                {
                    ProductoId = modeloProducto.ProductoId,
                    Cantidad = modeloProducto.Cantidad,
                    CodigoBarras = modeloProducto.CodigoBarras,
                    Nombre = modeloProducto.Nombre,
                    PrecioUnitario = modeloProducto.PrecioUnitario,
                    SucursalId = modeloProducto.SucursalId
                };
                _unit.producto.Actualiza(producto);

                var SalidaOk = new
                {
                    isSuccess = true,
                    producto,
                    mensaje = ModelState
                };
                return Json(SalidaOk);
            }

        }

        // Metodo para borrar un producto
        [HttpPost]
        public async Task<JsonResult> BorrarProducto(int Id)
        {
            _unit.producto.Borrar(Id);
            return Json(true);
        }

        //Metodo que actualiza cantidad de producto en bd al hacer una compra
        [HttpPost]
        public async Task<JsonResult> CompraProducto(int id)
        {
            Producto compraProducto = _unit.producto.GetProductoId(id);
            if (compraProducto.Cantidad > 0)
            {
                compraProducto.Cantidad = compraProducto.Cantidad - 1;
                _unit.producto.Actualiza(compraProducto);
               
            }
            var SalidaOk = new
            {
                isSuccess = true,
                compraProducto,
                mensaje = ModelState
            };
            return Json(SalidaOk);
        }
        #endregion
    }
}
