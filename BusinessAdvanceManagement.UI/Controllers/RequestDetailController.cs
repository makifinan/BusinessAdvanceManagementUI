using BusinessAdvanceManagement.Core;
using BusinessAdvanceManagement.Core.APIService;
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

        public RequestDetailController(RequestDetailApiService api)
        {
            _api = api;
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
    }
}
