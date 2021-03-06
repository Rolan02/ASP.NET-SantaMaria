using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santa_Maria.Models
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public AlumnoPromedio Alumno { get; set; }
        public Asignatura Asignatura { get; set; }

        public float Nota { get; set; }

        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}
