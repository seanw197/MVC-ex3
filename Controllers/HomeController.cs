using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_ex3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

/*
Lab 4 - MVC - Task 3 (TextMessage)

Build an ASP.Net MVC application that allows a user to send a text message.

A text message has a destination mobile phone number (10 digits) and content (max 140 characters).

A text message should be a model class.

Use model validation attributes as you see fit.

Use a new controller which displays a new view which shows a blank text message when the application is run.

The user should be able to edit the text message and send it.

When sent just re-direct to a page confirming that the message has been sent (and its details), no need to actually send it.

Let the user follow a link back to send another SMS from the confirmation page.

Use the scaffolding template available to build the view to edit the text message. 

*/

namespace MVC_ex3.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
