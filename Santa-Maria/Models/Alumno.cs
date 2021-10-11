using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santa_Maria.Models
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}
