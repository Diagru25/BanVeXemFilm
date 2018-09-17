namespace VeXemFilm.Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VeXemPhimDbContext : DbContext
    {
        public VeXemPhimDbContext()
            : base("name=VeXemPhimDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<LichChieu> LichChieux { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<PhongChieu> PhongChieux { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.GiaVe)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ve>()
                .Property(e => e.SoGhe)
                .IsUnicode(false);
        }
    }
}
