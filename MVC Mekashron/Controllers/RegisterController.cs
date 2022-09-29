using ICUTechServiceReference;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MVC_Mekashron.Controllers
{
    public class RegisterController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Index(string email, string password, string firstName, string lastName, string mobile)
        {
            ViewBag.IsDeveloperMode = true;
         
            var client = new ICUTechClient();
            var rawResponse = await client.RegisterNewCustomerAsync(email, password, firstName, lastName, mobile, 0, 0, "");
            ViewBag.ResponseData = JsonConvert.DeserializeObject(rawResponse.@return);

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
