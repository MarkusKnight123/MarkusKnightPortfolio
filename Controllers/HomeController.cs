
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Microsoft.AspNetCore.Mvc;
using PortfolioWebApp.Models;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using MimeKit;

namespace PortfolioWebApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Experience()
        {
            return View();
        }

         [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(EmailModel vm)
        {
            // Process the form submission (handled by Formspree), but no email sending code needed here.

            ModelState.Clear();
            ViewBag.Message = "Thank you for contacting us.";

            return View();
        }
        public IActionResult MyCV()
        {
            return View();
        }


        public IActionResult DementiaProj()
        {
            return View();
        }

        public IActionResult Papers()
        {
            return View();
        }

        public IActionResult CurrentProj()
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