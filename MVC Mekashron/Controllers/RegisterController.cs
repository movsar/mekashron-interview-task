using ICUTechServiceReference;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MVC_Mekashron.Controllers
{
    public class RegisterController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Index(LoginRequest loginRequest)
        {
            var client = new ICUTechServiceReference.ICUTechClient();
            //var rawResponse = await client.LoginAsync(username, password, "");
            //ViewBag.ResponseData = JsonConvert.DeserializeObject(rawResponse.@return);

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
