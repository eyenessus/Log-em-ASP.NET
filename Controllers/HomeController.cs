﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogWarning("Log de informações capturada da Index");
             //captura logs da index
            return View();
           
        }

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            DatabaseService dbs = new DatabaseService();
            dbs.CadastraInteresse(cad);
            return View("Index",cad);
        }

    }
}
