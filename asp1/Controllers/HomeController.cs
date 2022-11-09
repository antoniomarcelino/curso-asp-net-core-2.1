using asp1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace asp1.Controllers
{
    public class HomeController : Controller
    {
        // Retorno com ViewResult (após 8:40 do vídeo)
        public ViewResult Index()
        {
            return View("minhaView");
        }


        /*  Retorno com strings (até 8:40 do vídeo)
         
        public string Index()
        {
            return "Olá Mundo!";
        }

        public string Outro()
        {
            return "Outro método!";
        }
        */
    }
}
