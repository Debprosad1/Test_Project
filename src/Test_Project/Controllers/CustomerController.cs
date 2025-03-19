using Microsoft.AspNetCore.Mvc;

namespace Test_Project.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
