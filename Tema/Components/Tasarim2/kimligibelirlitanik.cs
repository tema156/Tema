using Microsoft.AspNetCore.Mvc;

namespace Tema.Components.Tasarim2
{
    public class kimligibelirlitanik : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}