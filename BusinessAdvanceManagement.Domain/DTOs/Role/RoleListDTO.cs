using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Domain.DTOs.Role
{
    public record RoleListDTO
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
