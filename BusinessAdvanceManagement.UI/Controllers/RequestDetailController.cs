using BusinessAdvanceManagement.Core;
using BusinessAdvanceManagement.Core.APIService;
using BusinessAdvanceManagement.Domain.DTOs.RequestDetail;
using BusinessAdvanceManagement.Domain.ViewModel.AdvanceRequestDetail;
using BusinessAdvanceManagement.Domain.ViewModel.RequestDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI.Controllers
{
    public class RequestDetailController : BaseController
    {
        RequestDetailApiService _api;
        private readonly AdvanceRequestDetailApiService _requestDetailApi;
        private readonly AdvanceRequestApiService _requestApi;

        public RequestDetailController(RequestDetailApiService api, AdvanceRequestDetailApiService requestDetailApi, AdvanceRequestApiService requestApi)
        {
            _api = api;
            _requestApi = requestApi;
            _requestDetailApi = requestDetailApi;
        }

        [HttpGet]
        public IActionResult PendingApproval()
        {
            var data = _api.GetAdvanceRequest(new AdvanceRequestHelper().StatuFilterQueryHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")))).Result.Datas;
            var viewModel = new PendingApprovalPageVM()
            {
                RolID = int.Parse(HttpContext.Session.GetString("WorkerRolID")),
                ConfirmAdvanceListDTOs = data
            };
            
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult PendingApprovalDetail(int advanceRequestID)
        {
            
            var viewModel = new PendingApprovalDetailPageVM()
            {
                OnlyAdvanceRequestListDTO = _requestApi.GetByRequestID(advanceRequestID).Result.Datas.FirstOrDefault(),
                AdvanceRequestDetailListDTO= _requestDetailApi.GetByRequest(advanceRequestID).Result.Datas
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult PendingApprovalDetail(RequestDetailAddDTO requestDetailAddDTO)
        {

           
            return new EmptyResult();
        }
    }
}
