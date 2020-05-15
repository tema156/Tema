using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tema.Controllers
{
    public class UyapOlaylariController : Controller
    {
        public IActionResult OlayGirisIslemleri(string value)
        {
            ViewBag.tasarimKodu = value;
            ViewBag.tasarimKoduu = "kafadar";
            return View();
        } 
        public IActionResult ihbarGirisIslemleri()
        {
            return View();
        }
        public IActionResult RaporOnayIslemleri()
        {
            return View();
        }
        public IActionResult OlayOnayIslemleri()
        {
            return View();
        }public IActionResult BelgeIslemleri()
        {
            return View();
        }public IActionResult ihbarIslemleri()
        {
            return View();
        }
    }
}