using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using StronglyTypingApplicationSettingsExample.Models;

namespace StronglyTypingApplicationSettingsExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Strongly Typing Application Settings Example
        private readonly IOptions<Teste> _options;

        //Strongly Typing Application Settings Example
        public HomeController(ILogger<HomeController> logger, IOptions<Teste> options)
        {
            _logger = logger;
            _options = options;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Strongly Typing Application Settings Example
        public JsonResult Testando()
        {
            return Json(new {_options.Value});
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
