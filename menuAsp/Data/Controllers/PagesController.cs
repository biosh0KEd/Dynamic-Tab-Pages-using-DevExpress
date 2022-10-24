using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using menuAsp.Data.Models.NavBar;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace menuAsp.Data.Controllers
{
    public class PagesController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult PartialView([FromBody]object datos) {
            Enlace dat = JsonConvert.DeserializeObject<Enlace>(datos.ToString());
            return PartialView($"~/Pages/{dat.Componente}.cshtml", Activator.CreateInstance("menuAsp", $"menuAsp.Pages.{dat.Model}").Unwrap());
        }
    }
}
