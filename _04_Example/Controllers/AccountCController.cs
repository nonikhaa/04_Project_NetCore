﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _04_Example.Controllers
{
    public class AccountCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}