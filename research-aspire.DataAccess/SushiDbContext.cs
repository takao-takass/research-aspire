using Microsoft.EntityFrameworkCore;
using research_aspire.DataAccess.Models;

namespace research_aspire.DataAccess;
public class SushiDbContext : DbContext
{
    public DbSet<MSushi> MSushis { get; set; }
    public DbSet<MSushiCategory> MSushiCategories { get; set; }
    public DbSet<TEatSushi> TEatSushis { get; set; }
}
