// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the AppController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace stoyanstoyanov_Web.Controllers.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Mvc;

    using stoyanstoyanov_Web.Services;
    using stoyanstoyanov_Web.ViewModels;

    public class AppController : Controller
    {
        private IMailService _mailService;

        public AppController(IMailService service)
        {
            _mailService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

                if (string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("", "Could not send email, configuration error");
                }
                
                var result = _mailService.SendMail(email,
                                      email,
                                      $"Message from {model.Name}, {model.Email}",
                                      model.Message
                                     );

                if (result)
                {
                    ModelState.Clear();

                    ViewBag.Message = "Mail Sent. Thanks!";
                }
                
            }
            
            return View();
        }
    }
}