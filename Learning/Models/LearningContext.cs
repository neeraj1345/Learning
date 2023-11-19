using Microsoft.EntityFrameworkCore;

namespace Learning.Models
{
    public class LearningContext : DbContext
    {
        public LearningContext(DbContextOptions<LearningContext> options) : base(options) 
        {
        }
        public DbSet<StudentModel> Tb_StudentDetail { get; set; }
    }

}
