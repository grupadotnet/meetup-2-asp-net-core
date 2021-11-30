using meetup_2_asp_net_core.Models;
using meetup_2_asp_net_core.Interfaces;

namespace meetup_2_asp_net_core.Services
{
    class CommentsService : ICommentsService
    {
        public Comment[] GetAllComments()
        {
            return new Comment[] {
                new Comment()
                {
                    Id = 1,
                    AddedAt = DateTime.Now,
                    Message = "Komentarz 1"
                },
                new Comment()
                {
                    Id = 2,
                    AddedAt = DateTime.Now.AddHours(-2),
                    Message = "Komentarz 2"
                }
            };
        }

        public void CreateComment(string message)
        {
            // Composite formatting
            Console.WriteLine("Comment craeted with content {0} at {1}", message, DateTime.Now);
        }
    }
}
