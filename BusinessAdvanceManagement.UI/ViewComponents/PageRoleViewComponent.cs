using BusinessAdvanceManagement.Core.APIService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI.ViewComponents
{
    public class PageRoleViewComponent : ViewComponent
    {
        private readonly GeneralApiService _generalApiService;

        public PageRoleViewComponent(GeneralApiService generalApiService)
        {
            _generalApiService = generalApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await  _generalApiService.GetByIDRolePage(int.Parse(HttpContext.Session.GetString("WorkerRolID")));
            return View(result.Datas);
        }
    }
}
