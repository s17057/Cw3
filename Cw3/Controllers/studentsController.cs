﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class studentsController : ControllerBase
    {
        [HttpGet]
        public string GetStudents() {
            return "Kowalski, Malewski";
        }
     }
}