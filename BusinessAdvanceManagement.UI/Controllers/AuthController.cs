using BusinessAdvanceManagement.Core.APIService;
using BusinessAdvanceManagement.Domain.DTOs.Worker;
using BusinessAdvanceManagement.Domain.ViewModel.Worker;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BusinessAdvanceManagement.UI.Controllers
{
    public class AuthController : BaseController
    {
        GeneralApiService _generalApiService;

        public AuthController(GeneralApiService generalApiService)
        {
            _generalApiService = generalApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var viewModel = new WorkerRegistrationVM()
            {
                RoleList = _generalApiService.GetAllRole().Result.Datas.Select(r => new SelectListItem() { Text = r.RoleName.ToString(), Value = r.RoleID.ToString() }).ToList(),
                UnitList = _generalApiService.GetAllUnit().Result.Datas.Select(u => new SelectListItem() { Text = u.UnitName, Value = u.UnitID.ToString() }).ToList()
            };
            return View(viewModel);

        }

        [HttpPost]
        public async Task<IActionResult> Register(WorkerAddUserDTO workerAddUserDTO)
        {
            return RedirectToAction("Login","Auth");
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
    }
}
