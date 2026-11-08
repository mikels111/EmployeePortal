using Microsoft.EntityFrameworkCore;
using EmployeePortal.Server.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace EmployeePortal.Server.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
    public DbSet<User> Users { get; set; }  

    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("user", schema:"dbo");
        modelBuilder.Entity<Role>().ToTable("role", schema:"dbo");

        modelBuilder.Entity<User>()
            .HasOne(u => u.Role)
            .WithMany(r => r.Users)  // Role debe tener Users
            .HasForeignKey(u => u.RoleId)
            .OnDelete(DeleteBehavior.Restrict);
        base.OnModelCreating(modelBuilder);
    }

}
