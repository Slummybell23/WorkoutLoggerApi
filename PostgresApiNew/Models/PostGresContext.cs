using Microsoft.EntityFrameworkCore;

namespace PostgresApiNew.Models;

public class PostGresContext : DbContext
{
    public PostGresContext(DbContextOptions<PostGresContext> options) : base(options) { }

    public DbSet<Persons> WorkoutModel { get; set; }
    
    
    
}