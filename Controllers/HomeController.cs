using Microsoft.AspNetCore.Mvc;
using proyectoMVC_JEAM.Models;
using System.Diagnostics;

namespace proyectoMVC_JEAM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            var personas = ObtenerPersonas(3);
            return View(personas);

        }

        private List<Persona> ObtenerPersonas(int cantidadPersonas)
        {
            var respuesta = new List<Persona>();
            for (int i = 0; i < cantidadPersonas; i++)
            {
                respuesta.Add(new Persona
                {
                    Id = Guid.NewGuid(),
                    Nombre = $"Personitas {i + 1}"

                });

            }
            return respuesta;

        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
            //return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        */

    }
}
