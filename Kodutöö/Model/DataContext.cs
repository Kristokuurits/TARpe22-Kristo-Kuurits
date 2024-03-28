using Microsoft.EntityFrameworkCore;

namespace ITB2203Application.Model;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    { }

    public DbSet<Event>? EventList { get; set; }

    public DbSet<Speaker>? SpeakerList { get; set; }

    public DbSet<Attendee>? AttendeeList { get; set; }
}
