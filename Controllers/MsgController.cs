using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_ex3.Models;

namespace MVC_ex3.Controllers
{
    public class MsgController : Controller
    {
        // GET: SMSController/Create
        public ActionResult Create()
        {
            // test comment
            return View();
        }


        // GET: MsgController

        public ActionResult Details(TextMsg msg)
        {
            return View(msg);
        }


        // POST: MsgController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TextMsg sms)
        {
            try
            {
                return RedirectToAction("Details", sms);
            }
            catch
            {
                return View();
            }
        }
    }
}
