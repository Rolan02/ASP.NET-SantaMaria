using Microsoft.AspNetCore.Mvc;
using Santa_Maria.Models;
using System;
using System.Linq;
namespace Santa_Maria.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            ViewBag.DataDinamico = "Prueba";
            var escuela =_context.Escuelas.FirstOrDefault();
            return View(escuela);
        }
        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
