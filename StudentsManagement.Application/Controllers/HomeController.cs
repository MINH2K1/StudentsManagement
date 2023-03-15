using Microsoft.AspNetCore.Mvc;
using StudentsManagement.Application.Models;
using StudentsManagement.Service.StudentResponsitory;
using System.Diagnostics;

namespace StudentsManagement.Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepo _repo;
      public HomeController ( IStudentRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var student = _repo.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}