using app2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace app2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Inicio");
        }

        [HttpGet]
        public ViewResult Formulario()
        {
            return View("Formulario");
        }

        [HttpPost]
        public ViewResult Formulario(RespostaConvidados resposta)
        {
            Repositorio.AdicionarResposta(resposta);
            return View("obrigado", resposta);
        }

        public ViewResult ListaConvidados()
        {
            return View("ListaFinal", Repositorio.ListaFinal.Where(c => c.Presente == true));
        }
    }
}
