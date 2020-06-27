using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationApi.Models
{
    public class Materia
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Profesor { get; set; }
        public string Cuatrimestre { get; set; }
        public string Horario { get; set; }
    }
}