using Lab.TpEF.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.TpEF.MVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string html = "https://digimon-api.vercel.app/api/digimon";
            HttpClient cliente = new HttpClient();
            var webConstains = await cliente.GetStringAsync(html);
            var list = JsonConvert.DeserializeObject<List<ApiView>>(webConstains);

            return View(list);
        }
    }
}