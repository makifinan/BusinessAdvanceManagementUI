﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Domain.DTOs.Worker
{
    public record WorkerAddUserDTO
    {
        public WorkerAddDTO WorkerAddDTO { get; set; }
        public string Password { get; set; }
    }
}
