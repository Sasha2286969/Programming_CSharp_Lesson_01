using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new IndexModel());
    }

    [HttpPost]
    public IActionResult Index(IndexModel model)
    {
        return View(model);
    }
}