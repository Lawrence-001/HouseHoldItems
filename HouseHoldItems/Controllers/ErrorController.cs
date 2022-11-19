using Microsoft.AspNetCore.Mvc;

namespace HouseHoldItems.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                  //  ViewBag.ErrorMessage = "Oops! Not Found, its not your lucky day!";
                    break;
            }
            return View("NotFound");
        }
    }
}
