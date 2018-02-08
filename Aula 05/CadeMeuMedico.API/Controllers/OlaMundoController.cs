using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CadeMeuMedico.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OlaMundoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult OlaMundo()
        {
            return Content("Ola Mundo ... estou funcionando ... ainda");
        }

        [HttpGet]
        public IActionResult OlaMundoDoTiago()
        {
            return Content("Ola Mundo do Tiago");
        }
    }
}