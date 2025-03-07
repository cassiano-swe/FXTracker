using FXTracker.domain.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext: DbContext{
    public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options){
    }

    public DbSet<Parity> Parities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
    }    
}