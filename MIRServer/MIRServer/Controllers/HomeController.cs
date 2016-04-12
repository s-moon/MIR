using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIRServer.Infrastructure;
using MIRServer.Models;

namespace MIRServer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(Incident incident)
        {
            Email.emailIncident(incident);
            return View();
        }
    }
}