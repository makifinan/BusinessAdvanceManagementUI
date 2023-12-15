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
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI.Controllers
{
    public class AdvanceRequestController : BaseController
    {
        private readonly AdvanceRequestApiService _api;
        private readonly GeneralApiService _generalapi;
        public AdvanceRequestController(AdvanceRequestApiService api, GeneralApiService generalapi)
        {
            _api = api;
            _generalapi = generalapi;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var viewModel = new AdvanceRequestVM() { ProjectList=_generalapi.GetAllProject().Result.Datas.Select(p=>new SelectListItem() {  Text=p.ProjectName,Value=p.ProjectID.ToString()}).ToList()};
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AdvanceRequestAddDTO advanceRequestAddDTO)
        {
            advanceRequestAddDTO.NextStatu = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
            advanceRequestAddDTO.WorkerID = int.Parse(HttpContext.Session.GetString("ID"));
            advanceRequestAddDTO.NextStageUser = int.Parse(HttpContext.Session.GetString("WorkerManagerID"));

            var result = await  _api.Add(advanceRequestAddDTO);
            if (result.Datas==null)
            {
                return BadRequest(result.Message);
            }
            return new EmptyResult();
        }

        [HttpGet]
        public async Task<IActionResult> GetByWorker()
        {
            var result = await _api.GetByWorker(int.Parse(HttpContext.Session.GetString("ID")));
            return View(result.Datas);
        }
    }
}
