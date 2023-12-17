using BusinessAdvanceManagement.Domain.DTOs.AdvanceRequest;
using BusinessAdvanceManagement.Domain.DTOs.AdvanceRequestDetail;
using BusinessAdvanceManagement.Domain.DTOs.RequestDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Domain.ViewModel.RequestDetail
{
    public class PendingApprovalDetailPageVM
    {
        public RequestDetailAddDTO RequestDetailAddDTO { get; set; }
        public OnlyAdvanceRequestListDTO OnlyAdvanceRequestListDTO { get; set; }
        public IEnumerable<AdvanceRequestDetailListDTO> AdvanceRequestDetailListDTO { get; set; }
    }
}
