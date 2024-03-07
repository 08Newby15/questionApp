using Microsoft.EntityFrameworkCore;

namespace QuestionsApp.Web.DB;


    public class QuestionsContext : DbContext
    {
        public DbSet<QuestionDb> Questions { get; set; }
        public DbSet<VoteDb> Votes { get; set; }
        public QuestionsContext(DbContextOptions options) : base(options)
        { }

    }
    
