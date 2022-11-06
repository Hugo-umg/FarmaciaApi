using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaAPI.Data
{
    public class MyDbConfig
    {
        public string StringConexion { get; set; }

        public MyDbConfig(string stringConexion) => StringConexion = stringConexion;
    }
}
