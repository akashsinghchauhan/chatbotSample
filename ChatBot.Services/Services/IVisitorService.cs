using ChatBot.Repository;

namespace ChatBot.Services
{
    public interface IVisitorService
    {
        long UpsertVisitors(Visitor visitor);
    }
}
