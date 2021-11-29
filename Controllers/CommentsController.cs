using Microsoft.AspNetCore.Mvc;

namespace meetup_1_asp_net_core.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return StatusCode(503);
        }

        public IActionResult Name(string name, int age)
        {
            return Ok(new {
                success = true,
                response = "Ok",
                firstName = name,
                age
            });
        }

        string Custom()
        {
            return "This won't be displayed";
        }
    }
}