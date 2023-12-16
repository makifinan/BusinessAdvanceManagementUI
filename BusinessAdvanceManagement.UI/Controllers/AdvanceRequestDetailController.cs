using BusinessAdvanceManagement.Core.APIService;
using BusinessAdvanceManagement.Domain.ViewModel.AdvanceRequestDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI.Controllers
{
    public class AdvanceRequestDetailController : BaseController
    {
        private readonly AdvanceRequestDetailApiService _api;
        private readonly AdvanceRequestApiService _requestApi;

        public AdvanceRequestDetailController(AdvanceRequestDetailApiService api, AdvanceRequestApiService requestApi)
        {
            _api = api;
            _requestApi = requestApi;
        }

        [HttpGet]
        public IActionResult GetByRequest(int advanceRequestID)
        {
            var viewModel = new AdvanceRequestDetailListPageVM()
            { 
                AdvanceRequestDetailListDTO = _api.GetByRequest(advanceRequestID).Result.Datas,
                AdvanceRequestListDTO = _requestApi.GetByWorker(int.Parse(HttpContext.Session.GetString("ID"))).Result.Datas.Where(r => r.AdvanceRequestID == advanceRequestID).FirstOrDefault()
            };
            
            return View(viewModel);
        }
    }
}
