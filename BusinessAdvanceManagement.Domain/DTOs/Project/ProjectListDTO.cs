﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Domain.DTOs.Project
{
    public record ProjectListDTO
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
    }
}
