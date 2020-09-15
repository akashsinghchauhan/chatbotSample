using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatBot.Repository
{
    public class ChatBotContext : IdentityDbContext
    {
        public ChatBotContext(DbContextOptions<ChatBotContext> options) : base(options)
        {

        }
        public DbSet<Visitor> Visitors { get; set; }

        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Public methods
        public override int SaveChanges()
        {
            return base.SaveChanges(true);
        }
        #endregion
    }
}
