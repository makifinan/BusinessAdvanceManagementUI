using BusinessAdvanceManagement.Domain.DTOs.RequestDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Domain.ViewModel.RequestDetail
{
    public class PendingApprovalPageVM
    {
        public IEnumerable<ConfirmAdvanceListDTO> ConfirmAdvanceListDTOs { get; set; }
        public int RolID { get; set; }
    }
}
