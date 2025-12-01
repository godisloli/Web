using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Lab1.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "this is my default action...";
        }

        public string Welcome(string name, int numTimes = 4)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
