using Microsoft.AspNetCore.Mvc;
using Santa_Maria.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Santa_Maria.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult Index()
        {
            return View(new Alumno { Nombre="Pepe Perez",UniqueId= Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAlumno()
        {
            var listaAlumnos = GenerarAlumnos();

            ViewBag.DataDinamico = "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View("MultipleAlumno",listaAlumnos);
        }
        private List<Alumno> GenerarAlumnos()
        {
            string[] nombre1 = { "Fernando", "Rolando", "Sergio", "Miguel", "Anibal", "Ana", "Rosa", "Maria", "Sonia", "Angy" };
            string[] apellido1 = { "Calle", "Rodriguez", "Quispe", "Orellana", "Torres", "Lopez", "Castellon", "Mendoza", "Garcia", "Olivera" };
            string[] nombre2 = { "del castillo", "del carmen", "Segundo", "Junior", "del pilar ", "del rosario ", "Tercero", "Cuarto", "Junior tercero", "Angel" }; ;
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno {
                                   Nombre = $"{n1}{n2}{a1}",
                                   UniqueId = Guid.NewGuid().ToString()
                               };
            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}
