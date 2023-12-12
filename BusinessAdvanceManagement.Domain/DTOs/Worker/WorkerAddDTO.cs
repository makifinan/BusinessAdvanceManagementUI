using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Domain.DTOs.Worker
{
    public record WorkerAddDTO
    {
        public int WorkerRolID { get; set; }
        public int WorkerManagerID { get; set; }
        public int WorkerBirimID { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public string WorkerEmail { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
