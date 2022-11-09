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
        public ViewResult Index()
        {
            ViewBag.Nome = "Joao";
            ViewBag.Apelido = "Ribeiro";
            ViewBag.Idade = 45;
            return View("Index");
        }

    }
}
