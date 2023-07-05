using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace NLogWeb.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            switch(statusCode)
            {
                case 404:
                    ViewBag.ErrorMsg = "Sorry, the resource you requested could not be found!";
                    break;
            }
            return View("NotFound");
        }

        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            // Retrieve the exception Details
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExceptionPath = exceptionHandlerPathFeature.Path;
            ViewBag.ExceptionMessage =exceptionHandlerPathFeature.Error.Message;
            ViewBag.StackTrace = exceptionHandlerPathFeature.Error.StackTrace;
            return View("DevError");
        }
    }
}
