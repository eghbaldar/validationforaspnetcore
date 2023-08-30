using Endpoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test50.Domain.Entities.Users;

namespace Endpoint.Site.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Users users)
        {
            return View();
        }

    }
}