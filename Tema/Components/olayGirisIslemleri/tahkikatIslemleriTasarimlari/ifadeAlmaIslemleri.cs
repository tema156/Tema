using Microsoft.AspNetCore.Mvc;

namespace Tema.Components.olayGirisIslemleri.tahkikatIslemleriTasarimlari
{
    public class ifadeAlmaIslemleri:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}