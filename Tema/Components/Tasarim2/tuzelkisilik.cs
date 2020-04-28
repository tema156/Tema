using Microsoft.AspNetCore.Mvc;

namespace Tema.Components.Tasarim2
{
    public class tuzelkisilik:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}