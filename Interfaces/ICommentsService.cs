using meetup_2_asp_net_core.Models;

namespace meetup_2_asp_net_core.Interfaces
{
    interface ICommentsService
    {
        Comment[] GetAllComments();

        void CreateComment(string message);
    }
}
