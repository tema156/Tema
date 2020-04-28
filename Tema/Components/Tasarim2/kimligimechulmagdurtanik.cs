using Microsoft.AspNetCore.Mvc;

namespace Tema.Components.Tasarim2
{
    public class kimligimechulmagdurtanik : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}