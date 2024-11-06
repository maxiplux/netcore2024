using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoAPI.Models;

namespace TodoAPI.AppDataContext;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    private readonly DbSettings _dbsettings;

    public ApplicationDbContext(IOptions<DbSettings> dbSettings, DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        _dbsettings = dbSettings.Value;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer(_dbsettings.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional model configurations can be added here
    }
}