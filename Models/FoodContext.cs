using Microsoft.EntityFrameworkCore;

namespace dockertraining_compose_salvador_jimenez.Models
{
    public class FoodContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        public FoodContext(DbContextOptions options) : base(options) {}

    }
}