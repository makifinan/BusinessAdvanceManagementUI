﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI.Controllers
{
    public class AdvanceRequestController : BaseController
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
