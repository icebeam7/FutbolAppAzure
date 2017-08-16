using System;
using Microsoft.WindowsAzure.MobileServices;

namespace FutbolAppAzure.Clases
{
    [DataTable("Equipo")]
    public class Equipo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
