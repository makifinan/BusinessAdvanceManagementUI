using BusinessAdvanceManagement.Domain.DTOs.AdvanceRequest;
using BusinessAdvanceManagement.Domain.DTOs.AdvanceRequestDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Domain.ViewModel.AdvanceRequestDetail
{
    public class AdvanceRequestDetailListPageVM
    {
        public AdvanceRequestListDTO AdvanceRequestListDTO { get; set; }
        public IEnumerable<AdvanceRequestDetailListDTO> AdvanceRequestDetailListDTO { get; set; }
    }
}
