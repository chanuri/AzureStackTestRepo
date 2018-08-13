using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AzureStackTest.Controllers
{
    public class AppoinmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}