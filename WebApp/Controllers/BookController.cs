using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class BookController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Echo(string name, int? count)
    {
        if (count == null)
        {
            return BadRequest(400);
        }
        ViewBag.Name = name;
        ViewBag.Count = count;
        return View();
    }

    public IActionResult EchoForm()
    {
        return View();
    }

    public IActionResult Sum(int a, int b)
    {
        return Content((a + b).ToString());
    }

    public IActionResult UserAgent()
    {
        return Content(Request.Headers.UserAgent.ToString());
    }

    public IActionResult Health()
    {
        return Json(new { status = "ok", time = DateTime.Now });
    }
}