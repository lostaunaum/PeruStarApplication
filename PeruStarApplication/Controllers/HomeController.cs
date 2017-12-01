using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeruStarApplication.ViewModels;
using PeruStarApplication.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace PeruStarApplication.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _configurationRoot;

        public HomeController(IMailService mailService, IConfigurationRoot configurationRoot)
        {
            _mailService = mailService;
            _configurationRoot = configurationRoot;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Reservations()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactView)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMail(_configurationRoot["MailSettings:Recepcion"], contactView.Email, "From Marco", contactView.Message);
                ViewBag.UserMessage = "Message Sent";

                ModelState.Clear();
            }

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
