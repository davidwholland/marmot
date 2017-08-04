using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Marmot.Controllers
{
    public class QueueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}