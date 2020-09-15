
namespace ChatBot.Repository
{
    public interface IVisitorsRepository
    {
        long UpsertVisitors(Visitor visitor);
    }
}
