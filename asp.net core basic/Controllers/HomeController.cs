using asp.net_core_basic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp.net_core_basic.Controllers
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
            return View();
        }
        public IActionResult Hizmetler()
        {
            return View();
        }

        public IActionResult Hakkimda()
        {
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();

        }
        public IActionResult Top_Wrapper()
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