﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HelloABP.Controllers;

namespace HelloABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : HelloABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
