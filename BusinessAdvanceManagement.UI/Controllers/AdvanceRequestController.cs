using BusinessAdvanceManagement.Business.Validation.AdvanceRequest;
using BusinessAdvanceManagement.Core;
using BusinessAdvanceManagement.Core.APIService;
using BusinessAdvanceManagement.Domain.DTOs.AdvanceRequest;
using BusinessAdvanceManagement.Domain.ViewModel.AdvanceRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI.Controllers
{
    public class AdvanceRequestController : BaseController
    {
        private readonly RequestDetailApiService _requestDetailApiService;
        private readonly AdvanceRequestApiService _api;
        private readonly GeneralApiService _generalapi;
        public AdvanceRequestController(AdvanceRequestApiService api, GeneralApiService generalapi, RequestDetailApiService requestDetailApiService)
        {
            _api = api;
            _generalapi = generalapi;
            _requestDetailApiService = requestDetailApiService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var viewModel = new AdvanceRequestVM() { ProjectList=_generalapi.GetAllProject().Result.Datas.Select(p=>new SelectListItem() {  Text=p.ProjectName,Value=p.ProjectID.ToString()}).ToList()};
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add( AdvanceRequestVM aadvanceRequestAddDTO)
        {
            var validator = new AdvanceRequestValidator();
            var validationResult = validator.Validate(aadvanceRequestAddDTO);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }

                return View(new AdvanceRequestVM() { ProjectList = _generalapi.GetAllProject().Result.Datas.Select(p => new SelectListItem() { Text = p.ProjectName, Value = p.ProjectID.ToString() }).ToList()});
            }


            aadvanceRequestAddDTO.AdvanceRequestAddDTO.NextStatu = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
            aadvanceRequestAddDTO.AdvanceRequestAddDTO.WorkerID = int.Parse(HttpContext.Session.GetString("ID"));
            aadvanceRequestAddDTO.AdvanceRequestAddDTO.NextStageUser = int.Parse(HttpContext.Session.GetString("WorkerManagerID"));
            aadvanceRequestAddDTO.AdvanceRequestAddDTO.AdvanceRequestStatus=new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
            var result =   await _api.Add(aadvanceRequestAddDTO.AdvanceRequestAddDTO);
            if (result.Datas==null)
            {
                return BadRequest(result.Message);
            }
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public async Task<IActionResult> GetByWorker()
        {
            
            var result = await _api.GetByWorker(int.Parse(HttpContext.Session.GetString("ID")));
            if (result.Datas==null)
            {
                return RedirectToAction("Index","Home");
            }
            return View(result.Datas);
        }

        [HttpGet]
        public async Task<IActionResult> GetAdvanceList()
        {

            var result = await _api.GetByApproving(14);
            if (result.Datas == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(result.Datas);
        }
    }
}
