using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;
using MySql.Data.MySqlClient;

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
            try
            {
                DatabaseService dbs = new DatabaseService();
                dbs.CadastraInteresse(cad);
                return Json(new { status = "Success" });
            }
            catch (MySqlException ex){
                _logger.LogError("Erro no MysqlException"+ ex.Message);
                return Json(new { status = "ERRO",mensagem="Falha ao gravar os dados" });
            }
            catch (Exception ex)
            {
                 _logger.LogError("Erro ao cadastrar"+ ex.Message);
                 return Json(new { status = "ERRO",mensagem="Falha ao gravar os dados" });
            }
            
          //  return View("Index",cad);
        }

    }
}
