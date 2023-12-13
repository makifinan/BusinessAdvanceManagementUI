using BusinessAdvanceManagement.Domain.ViewModel.Worker;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI.ViewComponents
{
    public class WorkerInformationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var viewModel = new WorkerLabelVM() {WorkerName= HttpContext.Session.GetString("WorkerName"),WorkerSurname= HttpContext.Session.GetString("WorkerSurname"), RoleName= HttpContext.Session.GetString("WorkerRoleName") };
            
            return View(viewModel);
        }
    }
}
