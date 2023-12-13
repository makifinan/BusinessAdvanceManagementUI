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
        AuthApiService _authApiService;

        public AuthController(GeneralApiService generalApiService, AuthApiService authApiService)
        {
            _generalApiService = generalApiService;
            _authApiService = authApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var viewModel = new WorkerRegistrationVM()
            {
                WorkerList=_generalApiService.GetAllWorker().Result.Datas.Select(w=> new SelectListItem() { Text=w.WorkerName.ToString()+w.WorkerSurname.ToString(),Value=w.WorkerID.ToString()}).ToList(),
                RoleList = _generalApiService.GetAllRole().Result.Datas.Select(r => new SelectListItem() { Text = r.RoleName.ToString(), Value = r.RoleID.ToString() }).ToList(),
                UnitList = _generalApiService.GetAllUnit().Result.Datas.Select(u => new SelectListItem() { Text = u.UnitName, Value = u.UnitID.ToString() }).ToList()
            };
            return View(viewModel);

        }

        [HttpPost]
        public async Task<IActionResult> Register(WorkerAddUserDTO workerAddUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(workerAddUserDTO);
            }

            var result = await _authApiService.Register(workerAddUserDTO);
            if (result.Datas!=null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(workerAddUserDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
    }
}
