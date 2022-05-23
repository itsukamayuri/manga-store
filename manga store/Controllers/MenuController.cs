using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace manga_store.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu2()
        {
            return View();
        }
        public IActionResult Menu3()
        {
            return View();
        }
    }
}
