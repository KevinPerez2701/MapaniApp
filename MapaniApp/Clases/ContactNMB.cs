using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaniApp
{
    public class ContactNMB
    {
        public int Id { get; set; }
        public string Nombre  { get; set; }
        public string Apellido { get; set; }
        public  DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Lactancia { get; set; }
        public string Parto { get; set; }
        public string PartidaNacimiento { get; set; }
        public string Discapacidad { get; set; }
        public string Ingreso { get; set; }
        public string Vacunas { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public byte[] Foto { get; set; }

        public string Parroquia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
    }
}
