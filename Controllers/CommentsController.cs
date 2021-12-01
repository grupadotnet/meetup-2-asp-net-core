using Microsoft.AspNetCore.Mvc;
using meetup_2_asp_net_core.Interfaces;

namespace meetup_2_asp_net_core.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentsService _commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        public IActionResult Index()
        {
            var comments = _commentsService.GetAllComments();

            return View(comments);
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