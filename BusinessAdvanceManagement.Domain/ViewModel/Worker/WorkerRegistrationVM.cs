using BusinessAdvanceManagement.Domain.DTOs.Worker;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessAdvanceManagement.Domain.ViewModel.Worker
{
    public class WorkerRegistrationVM
    {
        public WorkerAddUserDTO WorkerAddUserDTO { get; set; }
        public List<SelectListItem> UnitList { get; set; }
        public List<SelectListItem> RoleList { get; set; }
        public List<SelectListItem> WorkerList { get; set; }

    }
}
