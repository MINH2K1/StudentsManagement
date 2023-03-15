using Microsoft.AspNetCore.Mvc;

namespace StudentsManagement.Application.Areas.Admin.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
