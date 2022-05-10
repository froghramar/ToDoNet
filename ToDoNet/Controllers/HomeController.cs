using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoNet.Models;

namespace ToDoNet.Controllers;

public class HomeController : Controller
{
    private readonly ToDoContext _db;

    public HomeController(ToDoContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var toDoItems = await _db.ToDoItems.ToListAsync();
        ViewData["ToDoItems"] = toDoItems;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}