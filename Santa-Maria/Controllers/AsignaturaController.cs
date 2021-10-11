using Microsoft.AspNetCore.Mvc;
using Santa_Maria.Models;
using System;
using System.Collections.Generic;

namespace Santa_Maria.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var listaAsignaturas = new List<Asignatura>()
            {
                new Asignatura{Nombre = "Programacion",UniqueId= Guid.NewGuid().ToString()},
                new Asignatura{Nombre = "Matematicas",UniqueId= Guid.NewGuid().ToString()},
                new Asignatura{Nombre = "Literatura",UniqueId= Guid.NewGuid().ToString()},
                new Asignatura{Nombre = "Fisica",UniqueId= Guid.NewGuid().ToString()}
            };
            ViewBag.DataDinamico = "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View("MultipleAsignatura",listaAsignaturas);
        }
    }
}
