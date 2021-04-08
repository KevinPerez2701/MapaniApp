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
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public int IdCuidador { get; set; }
        public byte[] Foto { get; set; }
    }
}
