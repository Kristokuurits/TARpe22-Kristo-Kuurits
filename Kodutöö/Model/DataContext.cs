using Microsoft.EntityFrameworkCore;

namespace ITB2203Application.Model;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    { }

    public DbSet<Event>? Event { get; set; }

    public DbSet<Speaker>? Speaker { get; set; }

    public DbSet<Attendee>? Attendee { get; set; }
}
