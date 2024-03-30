using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Entities.Identity;
using OnlineMuhasebeServer.Domain.Repositories;
using System;
using System.Reflection.Emit;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Context;
public sealed class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Company> Companies { get; set; }
    public DbSet<AppUserCompanyAssociation> UserCompanies { get; set; }
    public DbSet<MainRoleAppRoleAssociation> MainRoleAppRoleAssociations { get; set; }
    public DbSet<MainRoleAppUserAssociation> MainRoleAppUserAssociations { get; set; }
    public DbSet<MainRole> MainRoles { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        //builder.ApplyConfigurationsFromAssembly(typeof(DependencyInjection).Assembly);
        builder.Entity<AppUserCompanyAssociation>().HasKey(p => new { p.AppUserId, p.CompanyId });
        builder.Entity<MainRoleAppRoleAssociation>().HasKey(p => new { p.RoleId, p.MainRoleId });
        builder.Entity<MainRoleAppUserAssociation>().HasKey(p => new { p.MainRoleId, p.CompanyId,p.UserId });
        builder.Entity<MainRoleAppUserAssociation>()
        .HasOne(e => e.AppUser)
        .WithMany()
        .HasForeignKey(e => e.UserId)
        .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<MainRoleAppUserAssociation>()
        .HasOne(e => e.MainRole)
        .WithMany()
        .HasForeignKey(e => e.MainRoleId)
        .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<MainRoleAppUserAssociation>()
        .HasOne(e => e.Company)
        .WithMany()
        .HasForeignKey(e => e.CompanyId)
        .OnDelete(DeleteBehavior.NoAction);



        builder.Entity<MainRoleAppRoleAssociation>()
     .HasOne(e => e.MainRole)
     .WithMany()
     .HasForeignKey(e => e.MainRoleId)
     .OnDelete(DeleteBehavior.NoAction);
        builder.Entity<MainRoleAppRoleAssociation>()
.HasOne(e => e.AppRole)
.WithMany()
.HasForeignKey(e => e.RoleId)
.OnDelete(DeleteBehavior.NoAction);
      
        // builder.Entity<MainRoleAppRoleAssociation>()
        //.HasOne(p => p.AppRole)
        //.WithMany(p => p.Id)
        //.HasForeignKey(p => p.RoleId)
        //.OnDelete(DeleteBehavior.NoAction);
        //modelBuilder.Entity<Category>()
        //    .HasMany(p => p.Products)
        //    .WithOne(p => p.Category)
        //    .HasForeignKey(p => p.CategoryId)
        //    .OnDelete(DeleteBehavior.NoAction);
        builder.Ignore<IdentityUserLogin<Guid>>();
        builder.Ignore<IdentityRoleClaim<Guid>>();
        builder.Ignore<IdentityUserToken<Guid>>();
        builder.Ignore<IdentityUserRole<Guid>>();
        builder.Ignore<IdentityUserClaim<Guid>>();


    }
    public class AppDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build().GetConnectionString("SqlServer"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
