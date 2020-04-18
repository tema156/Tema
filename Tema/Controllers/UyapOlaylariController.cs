using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tema.Controllers
{
    public class UyapOlaylariController : Controller
    {
        public IActionResult OlayGirisIslemleri()
        {
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
        }
    }
}