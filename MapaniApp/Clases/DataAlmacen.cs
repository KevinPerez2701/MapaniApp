using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaniApp
{
    public class DataAlmacen
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Programa { get; set; }
        public string Lote { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Cantidad { get; set; }
    }
}
