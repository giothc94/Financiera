using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatematicaFinanciera.Controllers
{
    public class MovimientosController:Controller
    {
        [HttpPost]
        public IActionResult RealizarPrestamo()
        {

            ViewBag.mensaje = "* Prestamo realizado exitosamente";
            return View("Correcto",ViewBag);
        }
        [HttpPost]
        [Route("/Servicio/Refinanciar",Name="Refinanciar")]
        public IActionResult RealizarRefinanciamiento(IFormCollection form)
        {
            var check = form["numMeses[]"];
            ViewBag.mensaje = check;
            return View("Correcto",ViewBag);
        }
    }
}