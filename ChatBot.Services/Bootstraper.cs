using ChatBot.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ChatBot.Services
{
    public static class Bootstraper
    {
        public static void InitializeRepository(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ChatBotContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ChatBotConnection")));
            services.AddScoped<IVisitorsRepository, VisitorsRepository>();
        }
        public static void InitializeServices(IServiceCollection services, IConfiguration configuration)
        {
            InitializeRepository(services, configuration);
            services.AddScoped<IVisitorService, VisitorService>();
        }
    }
}
