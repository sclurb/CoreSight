using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreSight.Models;
using CoreSight.Data;

namespace CoreSight.Controllers
{
    [Produces("application/json")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICoreSightRepository _repository;

        public HomeController(ILogger<HomeController> logger, ICoreSightRepository repository)
        {
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chart()
        {
            //var from = Convert.ToDateTime("5/2/2020");
            //var to= Convert.ToDateTime("5/10/2020");
            //var result = _repository.GetReadingsByDateRange( from,  to);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
