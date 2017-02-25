using System.Data.Entity;

namespace Db.Models
{
    public class EntityContext : DbContext
    {
        public EntityContext() : base("DbConn") {}
        public DbSet<QuestionDataModel> Questions { get; set; }
        public DbSet<QuizDataModel> Quiz { get; set; }
    }
}
