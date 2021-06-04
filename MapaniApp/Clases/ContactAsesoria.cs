using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaniApp
{
    public class ContactAsesoria
    {
        public int Id { get; set; }
        public int IdCuidador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
        public string Cedula { get; set; }
        public string Parroquia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Vinculo { get; set; }
        public string TipoDocumento { get; set; }
        public byte[] Documento { get; set; }
        public byte[] PDF { get; set; }
        public int IdNMB { get; set; }
        public string TipoCaso { get; set; }
        public string TipoAtencion { get; set; }
        public string Seguimiento { get; set; }
        public string Estatus { get; set; }
        public string Observacion { get; set; }
        public string Evolucion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
