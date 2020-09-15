
namespace ChatBot.Repository
{
    public class VisitorsRepository : IVisitorsRepository
    {
        private readonly ChatBotContext _chatBotContext;
        public VisitorsRepository(ChatBotContext chatBotContext)
        {
            _chatBotContext = chatBotContext;
        }
        public long UpsertVisitors(Visitor visitor)
        {
            _chatBotContext.Visitors.Add(visitor);
           return _chatBotContext.SaveChanges();
        }
    }
}
