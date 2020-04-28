using Microsoft.AspNetCore.Mvc;

namespace Tema.Components.Tasarim2
{
    public class kimligibelirlimadur:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}