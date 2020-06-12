using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aa.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View(111);
        }
    }
}