using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmrTaloniWebsite.Controllers
{
    public class OurServicesController : Controller
    {
        public IActionResult OurServices()
        {
            return View();
        }
    }
}
