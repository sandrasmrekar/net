using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class NumberSequenceController : Controller
    {
        public IActionResult Index()
        {
            // ReSharper disable once Mvc.ViewNotResolved

            return View();
        }
    }
}