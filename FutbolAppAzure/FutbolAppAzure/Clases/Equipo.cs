using System;
using Microsoft.WindowsAzure.MobileServices;

namespace FutbolAppAzure.Clases
{
    [DataTable("Equipo")]
    public class Equipo
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
