using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Wellcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        //Get: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        //Get: /HellowWorld/Welcome/
        //Requeres using System.Text.Encodings.Web
        //Get: /HellowWorld/Wellcome?name=isidro&numTimes=5
        //public string Welcome(string name = "David", int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");
        //}
    }
}
