using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    /*   // 
       // GET: /HelloWorld/
       public string Index()
       {
           return "HELLO ! This is my first try...";
       }
       // 
       // GET: /HelloWorld/Welcome/ 
       public string Welcome()
       {
           return "This is second try ...";
       }

       // GET: /HelloWorld/ThirdTry/

       public string ThirdTry()
       {
           return "This is my third try...";
       }

       // GET: /HelloWorld/Welcome/
       // Requires using System.Text.Encodings.Web;


       public string Try(string name, int numTimes = 1)
       {
           return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

       }
    */
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}