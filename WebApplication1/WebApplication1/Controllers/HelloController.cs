using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet, Route("Home/Index"), Route("")]
        public ActionResult Index(Name Con)
        {
            return View("~/Views/Home/Index.cshtml", Con);
        }

        [HttpPost]
        public IActionResult Welcome(Name ConName)
        {
            return View("~/Views/Home/Welcome.cshtml", ConName);
        }
    }
}