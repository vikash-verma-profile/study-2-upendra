using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Case_Study2.Models
{
    public partial class AirlineContext : DbContext
    {
        public AirlineContext()
        {
        }

        public AirlineContext(DbContextOptions<AirlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<TblBookingDetaile> TblBookingDetailes { get; set; }
        public virtual DbSet<TblBookingFlightUserMapping> TblBookingFlightUserMappings { get; set; }
        public virtual DbSet<TblFlightDetail> TblFlightDetails { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserDetail> TblUserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\;Database=Airline;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblBookingDetaile>(entity =>
            {
                entity.ToTable("tblBookingDetailes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArrivalTime).HasColumnType("datetime");

                entity.Property(e => e.DepartureTime).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.FlightName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfSeats)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("No_of_Seats");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBookingFlightUserMapping>(entity =>
            {
                entity.ToTable("tblBookingFlightUserMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.FlightId).HasColumnName("FlightID");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFlightDetail>(entity =>
            {
                entity.ToTable("tblFlightDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Arrival_Time");

                entity.Property(e => e.DepatureTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Depature_Time");

                entity.Property(e => e.Destination).HasMaxLength(100);

                entity.Property(e => e.FlightCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Flight_Charges");

                entity.Property(e => e.FlightName).HasMaxLength(100);

                entity.Property(e => e.Source).HasMaxLength(100);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tblUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasColumnType("date");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblUserDetail>(entity =>
            {
                entity.ToTable("tblUserDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
