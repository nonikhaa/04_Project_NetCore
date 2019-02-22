using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _04_Example_Entity;

namespace _04_Example.Controllers
{
    public class RoleManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(RoleModel role)
        //{
            
        //}
    }
}