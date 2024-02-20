using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmrTaloniWebsite.Controllers
{
    public class WhoWeAreController : Controller
    {
        public IActionResult WhoWeAre()
        {
            return View();
        }
    }
}
