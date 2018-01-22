using Microsoft.AspNetCore.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class OlaMundoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string ObterTeste()
        {
            return "teste";
        }
    }
}