using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaniApp
{
    public class ContactCuidador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string EstadoCivil { get; set; }
        public string CantidadHijos { get; set; }
        public string Cedula { get; set; }
        public string Transporte { get; set; }
        public byte[] Foto { get; set; }
        public string Parroquia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Parentesco { get; set; }
        public string Ocupacion { get; set; }
    }
}
