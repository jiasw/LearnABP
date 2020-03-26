using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloABP.Controllers;
using HelloABP.PhoneBooks;
using HelloABP.PhoneBooks.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HelloABP.Web.Controllers
{
    public class PersonsController : HelloABPControllerBase
    {

        private readonly IPersonAppService _personAppService;
        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> EditModal(int roleId)
        {
            
            var model = await _personAppService.GetPersonByIDAsync(new Abp.Application.Services.Dto.NullableIdDto<long>(roleId));

            return PartialView("_EditModal", model);
        }
    }
}