using Microsoft.AspNetCore.Mvc;

namespace StudentsManagement.Application.Areas.Admin.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
