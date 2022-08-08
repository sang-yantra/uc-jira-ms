using Infrastructure.JiraDev.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Infrastructure.JiraDev.Context
{
    public class JiraContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public JiraContext(DbContextOptions<JiraContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var dbconnectionstring = "Server=zm42x1ncy7o5.ap-south-2.psdb.cloud;Database=jira;user=391g0us8vf1v;password=pscale_pw_LZlrwzlieUaoL8QoOuL11Q85bEZ5Od4t0asb2EXVwF4;SslMode=VerifyFull;";
        //    optionsBuilder.UseMySql(dbconnectionstring, ServerVersion.AutoDetect(dbconnectionstring));
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Use Fluent API to configure  

        //    // Map entities to tables  
        //    modelBuilder.Entity<UserGroup>().ToTable("UserGroups");
        //    modelBuilder.Entity<User>().ToTable("Users");

        //    // Configure Primary Keys  
        //    modelBuilder.Entity<UserGroup>().HasKey(ug => ug.Id).HasName("PK_UserGroups");
        //    modelBuilder.Entity<User>().HasKey(u => u.Id).HasName("PK_Users");

        //    // Configure indexes  
        //    modelBuilder.Entity<UserGroup>().HasIndex(p => p.Name).IsUnique().HasDatabaseName("Idx_Name");
        //    modelBuilder.Entity<User>().HasIndex(u => u.FirstName).HasDatabaseName("Idx_FirstName");
        //    modelBuilder.Entity<User>().HasIndex(u => u.LastName).HasDatabaseName("Idx_LastName");

        //    // Configure columns  
        //    modelBuilder.Entity<UserGroup>().Property(ug => ug.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
        //    modelBuilder.Entity<UserGroup>().Property(ug => ug.Name).HasColumnType("nvarchar(100)").IsRequired();
        //    modelBuilder.Entity<UserGroup>().Property(ug => ug.CreationDateTime).HasColumnType("datetime").IsRequired();
        //    modelBuilder.Entity<UserGroup>().Property(ug => ug.LastUpdateDateTime).HasColumnType("datetime").IsRequired(false);

        //    modelBuilder.Entity<User>().Property(u => u.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.FirstName).HasColumnType("nvarchar(50)").IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.LastName).HasColumnType("nvarchar(50)").IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.UserGroupId).HasColumnType("int").IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.CreationDateTime).HasColumnType("datetime").IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.LastUpdateDateTime).HasColumnType("datetime").IsRequired(false);

        //    // Configure relationships  
        //    modelBuilder.Entity<User>().HasOne<UserGroup>().WithMany().HasPrincipalKey(ug => ug.Id).HasForeignKey(u => u.UserGroupId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Users_UserGroups");
        //}
    }
}

