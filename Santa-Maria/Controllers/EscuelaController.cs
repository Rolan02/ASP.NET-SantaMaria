using Microsoft.AspNetCore.Mvc;
using Santa_Maria.Models;
using System;

namespace Santa_Maria.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.Nombre = "Santa Maria Micaela";
            escuela.AñoDeCreación = 2005;
            escuela.Pais = "Bolivia";
            escuela.Ciudad = "Cochabamba";
            escuela.Dirección = "Villa Pagador";
            escuela.TipoEscuela = TiposEscuela.PreEscolar;
            escuela.UniqueId = Guid.NewGuid().ToString();
            ViewBag.DataDinamico = "Prueba";
            return View(escuela);
        }
    }
}
