using FarmaciaAPI.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public ProductosController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {
            return Ok(await _productoRepository.GetProductos(0));
        }

        [HttpGet("{idProducto}")]
        public async Task<IActionResult> GetProducto(int idProducto)
        {
            return Ok(await _productoRepository.GetProducto(idProducto));
        }

        [HttpGet("{idSucursal}, {idCategoria}")]
        public async Task<IActionResult> GetProductosCategoria(int idSucursal, int idCategoria)
        {
            return Ok(await _productoRepository.GetProductosCategoria(idSucursal, idCategoria));
        }
    }
}
