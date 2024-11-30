using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index() //action method, used for handling requests
    {
        //IActionResult in an abstract of all possible return types
        return View();
    }
}