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
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Pediatra { get; set; }
        public string IdNMB { get; set; }
        public string Despachado { get; set; }
        public int Diferido { get; set; }
        public string Flag { get; set; }
    }
}
