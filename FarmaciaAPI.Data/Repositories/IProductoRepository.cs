using FarmaciaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaAPI.Data.Repositories
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Productos>> GetProductos(int idSucursal);
        Task<Productos> GetProducto(int idProducto);
        Task<IEnumerable<Productos>> GetProductosCategoria(int idSucursal, int idCategoria);
    }
}
