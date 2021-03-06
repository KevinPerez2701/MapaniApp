using System;

namespace MapaniApp
{
    public class MapaniUsers
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Posicion { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        public string Asistencia { get; set; }
        public string Rol { get; set; }
    }
}
