using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BankProgram1.Models;

#nullable disable

namespace BankProgram1.Data
{
    public partial class aspnetBankProgram1D8764314D8AA4375AA2F5458F84AAB68Context : DbContext
    {
        public aspnetBankProgram1D8764314D8AA4375AA2F5458F84AAB68Context()
        {
        }

        public aspnetBankProgram1D8764314D8AA4375AA2F5458F84AAB68Context(DbContextOptions<aspnetBankProgram1D8764314D8AA4375AA2F5458F84AAB68Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-BankProgram1-D8764314-D8AA-4375-AA2F-5458F84AAB68;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BeginningBalance).HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.AccountOwnerNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_AspNetUsers");
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TransferAmount).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TransferType).IsFixedLength(true);

                entity.HasOne(d => d.ToAccountNavigation)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.ToAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transfer_Account");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
