using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Edit(int? id)
    {
        var category = new Category
        {
            CateogoryId = id.HasValue ? id.Value : 0
        };
        
        return View(category); // we provide the instance of the model class into the view
    }
}