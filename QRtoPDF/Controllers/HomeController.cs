using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRtoPDF.Models;
using Rotativa.AspNetCore;
using System.Diagnostics;


namespace QRtoPDF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult Index(string t)
        {
            
           
            return new ViewAsPdf("Index", Models.QRCode.GetOne(t));
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
