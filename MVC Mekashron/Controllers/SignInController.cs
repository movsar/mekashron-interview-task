using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MVC_Mek.Controllers
{
    public class SignInController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            ViewBag.IsDeveloperMode = false;

            var client = new ICUTechServiceReference.ICUTechClient();
            var rawResponse = await client.LoginAsync(username, password, "");
            ViewBag.ResponseData = JsonConvert.DeserializeObject(rawResponse.@return);
            
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
