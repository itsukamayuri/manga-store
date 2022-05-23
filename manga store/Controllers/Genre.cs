using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace manga_store.Controllers
{
    public class Genre : Controller
    {
        public IActionResult kinhdi()
        {
            return View();
        }
        public IActionResult trinhtham()
        {
            return View();
        }
        public IActionResult haihuoc()
        {
            return View();
        }
        public IActionResult lichsu()
        {
            return View();
        }
    }
}
