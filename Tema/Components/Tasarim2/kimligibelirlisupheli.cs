using Microsoft.AspNetCore.Mvc;

namespace Tema.Components.Tasarim2
{
    public class kimligibelirlisupheli : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}