using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatematicaFinanciera.Models;
using System.Data.SqlClient;
using System.Data.Common;
using MatematicaFinanciera.Models.BDD;

namespace MatematicaFinanciera.Controllers
{
    public class HomeController : Controller
    {
        private DataBaseConnection dbc = new DataBaseConnection();
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
