using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santa_Maria.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {

        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}
