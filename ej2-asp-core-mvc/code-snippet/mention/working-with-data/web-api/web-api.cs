﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MentionController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.query = "new ej.data.Query().select(['FirstName','Country', 'EmployeeID']).take(8).requiresCount()";
            return View();
        }
    }
}