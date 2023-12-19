using BusinessAdvanceManagement.Domain.DTOs.AdvanceRequest;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Domain.ViewModel.AdvanceRequest
{
    public class AdvanceRequestVM
    {
        
        public AdvanceRequestAddDTO AdvanceRequestAddDTO { get; set; }
        public List<SelectListItem> ProjectList { get; set; }
    }
}
