using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public string  Index()
        {
            return "This is my default action... ";
        }

        // GET:/
        public string Welcome()
        {
            return "This is my Welcome action...";
        }
    }
}
