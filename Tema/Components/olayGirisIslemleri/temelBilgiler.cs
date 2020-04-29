using Microsoft.AspNetCore.Mvc;

namespace Tema.Components.olayGirisIslemleri
{
    public class temelBilgiler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}