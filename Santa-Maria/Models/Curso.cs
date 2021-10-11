using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santa_Maria.Models
{
    public class Curso
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<AlumnoPromedio> Alumnos { get; set; }
        public string Dirección { get; set; }
    }
}
