using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Project_.Models;

namespace Project_
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdsDatum> AdsData { get; set; } = null!;
        public virtual DbSet<UserDatum> UserData { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Project");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdsDatum>(entity =>
            {
                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city ");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.EColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eColor");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("make");

                entity.Property(e => e.Mileage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mileage");

                entity.Property(e => e.MobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobNumber");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Price)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.RegisterdIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registerdIn");

                entity.Property(e => e.SellerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sellerName");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.Variant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("variant");
            });

            modelBuilder.Entity<UserDatum>(entity =>
            {
                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fName");

                entity.Property(e => e.Gend)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gend");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Number)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.Pswd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pswd");

                entity.Property(e => e.SName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public override int SaveChanges()
        {
            var tracker = ChangeTracker;
            foreach (var entry in tracker.Entries())
            {
                if (entry.Entity is Entity)
                {
                    string UserName = Environment.GetEnvironmentVariable("userId");
                    var referenceEntity = entry.Entity as Entity;
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedDate = DateTime.Now;
 
                            referenceEntity.CreatedByUser = UserName;
                            break;
                        case EntityState.Deleted:
                        case EntityState.Modified:
                            referenceEntity.ModifiedDate = DateTime.Now;
                            referenceEntity.ModifiedByUser = UserName;//hard coded user id
                            break;
                        default:
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
