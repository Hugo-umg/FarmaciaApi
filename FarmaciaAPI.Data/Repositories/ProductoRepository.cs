using Dapper;
using FarmaciaAPI.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaAPI.Data.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private MyDbConfig _myDbConfig;

        public ProductoRepository(MyDbConfig myDbConfig)
        {
            _myDbConfig = myDbConfig;
        }

        protected MySqlConnection dbConection()
        {
            return new MySqlConnection(_myDbConfig.StringConexion);
        }

        public async Task<Productos> GetProducto(int idProducto)
        {
            var db = dbConection();

            var sql = @"Select *
                          From productos
                         Where idproducto = @idProducto";

            return await db.QueryFirstOrDefaultAsync<Productos>(sql, new { idProducto });
        }

        public async Task<IEnumerable<Productos>> GetProductos(int idSucursal)
        {
            var db = dbConection();

            string sql;

            if (idSucursal != 0)
            {
                sql = @"Select *
                          From productos
                         Where idsucu_c = @idSucursal";

                return await db.QueryAsync<Productos>(sql, new { idSucursal });
            }
            else
            {
                sql = @"Select *
                          From productos";
                return await db.QueryAsync<Productos>(sql, new { });
            }
        }

        public async Task<IEnumerable<Productos>> GetProductosCategoria(int idSucursal, int idCategoria)
        {
            var db = dbConection();

            var sql = @"Select *
                          From productos
                         Where idsucu_c = @idSucursal
                           And idcategoria = @idCategoria";

            return await db.QueryAsync<Productos>(sql, new { idSucursal, idCategoria });
        }
    }
}
