using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloABP.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HelloABP.Web.Controllers
{
    public class PersonsController : HelloABPControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}