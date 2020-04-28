using Microsoft.AspNetCore.Mvc;

namespace Tema.Components.Mernis
{
    public class mernisBilgileri:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}