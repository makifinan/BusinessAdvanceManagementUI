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
        private readonly GeneralApiService _generalApi;

        public RequestDetailController(RequestDetailApiService api, AdvanceRequestDetailApiService requestDetailApi, AdvanceRequestApiService requestApi, GeneralApiService generalApi)
        {
            _api = api;
            _requestApi = requestApi;
            _requestDetailApi = requestDetailApi;
            _generalApi = generalApi;
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
                RoleID= int.Parse(HttpContext.Session.GetString("WorkerRolID")),
                OnlyAdvanceRequestListDTO = _requestApi.GetByRequestID(advanceRequestID).Result.Datas.FirstOrDefault(),
                AdvanceRequestDetailListDTO= _requestDetailApi.GetByRequest(advanceRequestID).Result.Datas
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult PendingApprovalDetailAdd(RequestDetailAddDTO requestDetailAddDTO, string operation)
        {
            if (operation=="add")
            {
                var parametre1 = new AdvanceRequestHelper().RequestDetailAddNextStageUserHelper(_generalApi.GetByRoleIDRule(int.Parse(HttpContext.Session.GetString("WorkerRolID"))).Result.Datas.FirstOrDefault(), _requestApi.GetByRequestID(requestDetailAddDTO.AdvanceRequestID).Result.Datas.FirstOrDefault().Amount, int.Parse(HttpContext.Session.GetString("WorkerRolID")));

                if (parametre1 == 1)
                {
                    requestDetailAddDTO.NextStageUser = 6;
                    requestDetailAddDTO.NextStatu = 10;
                    requestDetailAddDTO.ApprovingDisapproving = int.Parse(HttpContext.Session.GetString("ID"));
                    requestDetailAddDTO.ApprovingDisapprovingRole = int.Parse(HttpContext.Session.GetString("WorkerRolID"));
                }
                if (parametre1==2)
                {
                    requestDetailAddDTO.NextStageUser = int.Parse(HttpContext.Session.GetString("WorkerManagerID"));
                    requestDetailAddDTO.NextStatu = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                }
                if (parametre1==3)
                {
                    //onay sınırları içerisinde, finans müdürüne ata
                    requestDetailAddDTO.NextStageUser = 6;
                    requestDetailAddDTO.NextStatu = 10;
                    requestDetailAddDTO.ApprovingDisapproving= int.Parse(HttpContext.Session.GetString("ID"));
                    requestDetailAddDTO.ApprovingDisapprovingRole= int.Parse(HttpContext.Session.GetString("WorkerRolID"));
                }

                requestDetailAddDTO.StatuID = new AdvanceRequestHelper().RequestDetailAddStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                requestDetailAddDTO.CreatedDate = DateTime.Now;
                requestDetailAddDTO.TransactionOwner = int.Parse(HttpContext.Session.GetString("ID"));
                requestDetailAddDTO.RequestStatuID = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                var result = _api.Add(requestDetailAddDTO);
            }
            if (operation=="red")
            {
                requestDetailAddDTO.StatuID = 13;
                requestDetailAddDTO.ApprovingDisapproving = int.Parse(HttpContext.Session.GetString("ID"));
                requestDetailAddDTO.ApprovingDisapprovingRole = int.Parse(HttpContext.Session.GetString("WorkerRolID"));
                
                var result = _api.Red(requestDetailAddDTO);
            }
            if (operation=="insert")
            {
                //fm
                requestDetailAddDTO.StatuID = new AdvanceRequestHelper().RequestDetailAddStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                requestDetailAddDTO.CreatedDate = DateTime.Now;
                requestDetailAddDTO.TransactionOwner = int.Parse(HttpContext.Session.GetString("ID"));
                requestDetailAddDTO.RequestStatuID = 14;
                requestDetailAddDTO.NextStageUser = 8;
                requestDetailAddDTO.NextStatu = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));

                var result = _api.Add(requestDetailAddDTO);
            }
            if (operation=="makbuz")
            {

            }
           
            return RedirectToAction("Index","Home");
        }
    }
}
