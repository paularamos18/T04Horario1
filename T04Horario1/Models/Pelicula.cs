using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T04Horario1.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public int Sala { get; set; }
        public DateTime Horario { get; set; }
        public string Clasificacion { get; set; }
    }
}