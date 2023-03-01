
using Microsoft.AspNetCore.Mvc;
namespace asp.net_core_basic.Controllers

{
    public class ProductController : Controller
    {
        //create a new object for send data from controller to views

        public IActionResult Products()
        {
            return View();
        }
    }
}
