﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatingApp.DataAccessLayer.Models
{
    public partial class DatingAppWinFormsContext : DbContext
    {
        public DatingAppWinFormsContext()
        {
        }

        public DatingAppWinFormsContext(DbContextOptions<DatingAppWinFormsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<RegistrationUser> RegistrationUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BMNM0ER;Database=DatingAppWinForms;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Recepient)
                    .WithMany(p => p.ChatRecepients)
                    .HasForeignKey(d => d.RecepientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Chats__Recepient__4F7CD00D");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.ChatSenders)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Chats__SenderId__5070F446");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("Profile");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Profile)
                    .HasForeignKey<Profile>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Profile__Id__4CA06362");
            });

            modelBuilder.Entity<RegistrationUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Registra__1788CC4CCF3A91DD");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
