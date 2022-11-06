using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaAPI.Model
{
    public class Productos
    {
        public int idproducto { get; set; }
        public string codigo { get; set; }
        public int idlote { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public int stock { get; set; }
        public int stockminimo { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_Venta { get; set; }
        public decimal descuento { get; set; }
        public string ventasujeta { get; set; }
        public DateTime fecharegistro { get; set; }
        public string reg_sanitario { get; set; }
        public int idcategoria { get; set; }
        public int idpresentacion { get; set; }
        public int idlab_pro { get; set; }
        public int idsintoma { get; set; }
        public string estado { get; set; }
        public int idsucu_c { get; set; }
        public string imagen_nombre { get; set; }
    }
}
