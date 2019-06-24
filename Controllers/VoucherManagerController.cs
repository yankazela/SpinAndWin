﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpinAndWin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherManagerController : ControllerBase
    {
        [Route("fetch-winningid")]
        //[HttpGet]
        public int GetWinningId()
        {
            return 3;
        }
    }
}