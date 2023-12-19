using BusinessAdvanceManagement.Business.Validation.Worker;
using BusinessAdvanceManagement.Core.APIService;
using BusinessAdvanceManagement.Domain.DTOs.Worker;
using BusinessAdvanceManagement.Domain.ViewModel.Worker;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> Register(WorkerRegistrationVM wworkerAddUserDTO)
        {
            var validator = new WorkerValidator();
            var validationResult = validator.Validate(wworkerAddUserDTO);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }

                return View(new WorkerRegistrationVM() {
                    WorkerList = _generalApiService.GetAllWorker().Result.Datas.Select(w => new SelectListItem() { Text = w.WorkerName.ToString() + w.WorkerSurname.ToString(), Value = w.WorkerID.ToString() }).ToList(),
                    RoleList = _generalApiService.GetAllRole().Result.Datas.Select(r => new SelectListItem() { Text = r.RoleName.ToString(), Value = r.RoleID.ToString() }).ToList(),
                    UnitList = _generalApiService.GetAllUnit().Result.Datas.Select(u => new SelectListItem() { Text = u.UnitName, Value = u.UnitID.ToString() }).ToList()
                });
            }

            var result = await _authApiService.Register(wworkerAddUserDTO.WorkerAddUserDTO);
            if (result.Datas!=null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(new WorkerRegistrationVM());
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {

            return View(new WorkerLoginDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Login(WorkerLoginDTO workerLoginDTO)
        {

            var validator = new WorkerLoginValidator();
            var validationResult = validator.Validate(workerLoginDTO);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }

                return View(workerLoginDTO);
            }


            var result = await _authApiService.Login(workerLoginDTO);
            if (result==null)
            {
                return null;
            }
            HttpContext.Session.SetString("ID",result.WorkerID.ToString());
            HttpContext.Session.SetString("WorkerName",result.WorkerName.ToString());
            HttpContext.Session.SetString("WorkerSurname",result.WorkerSurname.ToString());
            HttpContext.Session.SetString("WorkerRolID",result.WorkerRolID.ToString());
            HttpContext.Session.SetString("WorkerRoleName",result.RoleName.ToString());
            HttpContext.Session.SetString("WorkerManagerID",result.WorkerManagerID.ToString());
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Auth");
        }
    }
}
