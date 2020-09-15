using System;
using ChatBot.Repository;

namespace ChatBot.Services
{
    class VisitorService : IVisitorService
    {
        private readonly IVisitorsRepository _visitorsRepository;

        public VisitorService(IVisitorsRepository visitorsRepository)
        {
            _visitorsRepository = visitorsRepository;
        }
        public long UpsertVisitors(Visitor visitor)
        {
            long id = _visitorsRepository.UpsertVisitors(visitor);
            return id;
        }
    }
}
