using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MVC_Mekashron.Controllers
{
    public class SignInController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            var client = new ICUTechServiceReference.ICUTechClient();
            var rawResponse = await client.LoginAsync(username, password, "");
            JObject responseData = (JObject)JsonConvert.DeserializeObject(rawResponse.@return);

            ViewData["ResponseData"] = responseData;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
