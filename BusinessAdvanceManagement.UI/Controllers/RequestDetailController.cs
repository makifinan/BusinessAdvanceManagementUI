using BusinessAdvanceManagement.Business.Validation.RequestDetail;
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
            var data = _api.GetAdvanceRequest(new AdvanceRequestHelper().StatuFilterQueryHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")))).Result;
            if (data.Datas==null)
            {
                return RedirectToAction("Index","Home");
            }
            var viewModel = new PendingApprovalPageVM()
            {
                RolID = int.Parse(HttpContext.Session.GetString("WorkerRolID")),
                ConfirmAdvanceListDTOs = data.Datas
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
        public IActionResult PendingApprovalDetail(PendingApprovalDetailPageVM rrequestDetailAddDTO, string operation)
        {
            var validator = new RequestDetailValidator();
            var validationResult = validator.Validate(rrequestDetailAddDTO);
            

            if (operation=="add")
            {
                var parametre1 = new AdvanceRequestHelper().RequestDetailAddNextStageUserHelper(_generalApi.GetByRoleIDRule(int.Parse(HttpContext.Session.GetString("WorkerRolID"))).Result.Datas.FirstOrDefault(), _requestApi.GetByRequestID(rrequestDetailAddDTO.RequestDetailAddDTO.AdvanceRequestID).Result.Datas.FirstOrDefault().Amount, int.Parse(HttpContext.Session.GetString("WorkerRolID")));

                if (parametre1 == 1)
                {
                    rrequestDetailAddDTO.RequestDetailAddDTO.NextStageUser = 6;
                    rrequestDetailAddDTO.RequestDetailAddDTO.NextStatu = 10;
                    rrequestDetailAddDTO.RequestDetailAddDTO.ApprovingDisapproving = int.Parse(HttpContext.Session.GetString("ID"));
                    rrequestDetailAddDTO.RequestDetailAddDTO.ApprovingDisapprovingRole = int.Parse(HttpContext.Session.GetString("WorkerRolID"));
                    rrequestDetailAddDTO.RequestDetailAddDTO.RequestStatuID = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                }
                if (parametre1==2)
                {
                    rrequestDetailAddDTO.RequestDetailAddDTO.NextStageUser = int.Parse(HttpContext.Session.GetString("WorkerManagerID"));
                    rrequestDetailAddDTO.RequestDetailAddDTO.NextStatu = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                    rrequestDetailAddDTO.RequestDetailAddDTO.RequestStatuID = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                }
                if (parametre1==3)
                {
                    //onay sınırları içerisinde, finans müdürüne ata
                    rrequestDetailAddDTO.RequestDetailAddDTO.NextStageUser = 6;
                    rrequestDetailAddDTO.RequestDetailAddDTO.NextStatu = 10;
                    rrequestDetailAddDTO.RequestDetailAddDTO.ApprovingDisapproving= int.Parse(HttpContext.Session.GetString("ID"));
                    rrequestDetailAddDTO.RequestDetailAddDTO.ApprovingDisapprovingRole= int.Parse(HttpContext.Session.GetString("WorkerRolID"));
                    rrequestDetailAddDTO.RequestDetailAddDTO.RequestStatuID = 10;
                }

                

                if (!validationResult.IsValid)
                {
                    foreach (var error in validationResult.Errors)
                    {
                        ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    }

                    return View(new PendingApprovalDetailPageVM()
                    {
                        RoleID = int.Parse(HttpContext.Session.GetString("WorkerRolID")),
                        OnlyAdvanceRequestListDTO = _requestApi.GetByRequestID(rrequestDetailAddDTO.RequestDetailAddDTO.AdvanceRequestID).Result.Datas.FirstOrDefault(),
                        AdvanceRequestDetailListDTO = _requestDetailApi.GetByRequest(rrequestDetailAddDTO.RequestDetailAddDTO.AdvanceRequestID).Result.Datas
                    });
                }

                rrequestDetailAddDTO.RequestDetailAddDTO.StatuID = new AdvanceRequestHelper().RequestDetailAddStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                rrequestDetailAddDTO.RequestDetailAddDTO.CreatedDate = DateTime.Now;
                rrequestDetailAddDTO.RequestDetailAddDTO.TransactionOwner = int.Parse(HttpContext.Session.GetString("ID"));
               
                var result = _api.Add(rrequestDetailAddDTO.RequestDetailAddDTO);
            }
            if (operation=="red")
            {
                rrequestDetailAddDTO.RequestDetailAddDTO.ConfirmAmount = 0;
                rrequestDetailAddDTO.RequestDetailAddDTO.StatuID = 13;
                rrequestDetailAddDTO.RequestDetailAddDTO.ApprovingDisapproving = int.Parse(HttpContext.Session.GetString("ID"));
                rrequestDetailAddDTO.RequestDetailAddDTO.ApprovingDisapprovingRole = int.Parse(HttpContext.Session.GetString("WorkerRolID"));
                
                var result = _api.Red(rrequestDetailAddDTO.RequestDetailAddDTO);
            }
            if (operation=="insert")
            {
                //fm
                rrequestDetailAddDTO.RequestDetailAddDTO.StatuID = new AdvanceRequestHelper().RequestDetailAddStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                rrequestDetailAddDTO.RequestDetailAddDTO.CreatedDate = DateTime.Now;
                rrequestDetailAddDTO.RequestDetailAddDTO.TransactionOwner = int.Parse(HttpContext.Session.GetString("ID"));
                rrequestDetailAddDTO.RequestDetailAddDTO.RequestStatuID = 14;
                rrequestDetailAddDTO.RequestDetailAddDTO.NextStageUser = 8;
                rrequestDetailAddDTO.RequestDetailAddDTO.NextStatu = new AdvanceRequestHelper().NextStatuHelper(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
                
                if (!validationResult.IsValid)
                {
                    foreach (var error in validationResult.Errors)
                    {
                        ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    }

                    return View(new PendingApprovalDetailPageVM()
                    {
                        RoleID = int.Parse(HttpContext.Session.GetString("WorkerRolID")),
                        OnlyAdvanceRequestListDTO = _requestApi.GetByRequestID(rrequestDetailAddDTO.RequestDetailAddDTO.AdvanceRequestID).Result.Datas.FirstOrDefault(),
                        AdvanceRequestDetailListDTO = _requestDetailApi.GetByRequest(rrequestDetailAddDTO.RequestDetailAddDTO.AdvanceRequestID).Result.Datas
                    });
                }

                var result = _api.Add(rrequestDetailAddDTO.RequestDetailAddDTO);
            }
            if (operation=="makbuz")
            {
                
                if (!validationResult.IsValid)
                {
                    foreach (var error in validationResult.Errors)
                    {
                        ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    }

                    return View(new PendingApprovalDetailPageVM()
                    {
                        RoleID = int.Parse(HttpContext.Session.GetString("WorkerRolID")),
                        OnlyAdvanceRequestListDTO = _requestApi.GetByRequestID(rrequestDetailAddDTO.RequestDetailAddDTO.AdvanceRequestID).Result.Datas.FirstOrDefault(),
                        AdvanceRequestDetailListDTO = _requestDetailApi.GetByRequest(rrequestDetailAddDTO.RequestDetailAddDTO.AdvanceRequestID).Result.Datas
                    });
                }
            }
           
            return RedirectToAction("Index","Home");
        }
    }
}
