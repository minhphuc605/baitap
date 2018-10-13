namespace Model.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Quanlyveso : DbContext
    {
        public Quanlyveso()
            : base("name=Quanlyveso")
        {
        }

        public virtual DbSet<DAILY> DAILies { get; set; }
        public virtual DbSet<GIAI> GIAIs { get; set; }
        public virtual DbSet<KETQUAXOSO> KETQUAXOSOes { get; set; }
        public virtual DbSet<LOAIVESO> LOAIVESOes { get; set; }
        public virtual DbSet<PHATHANH> PHATHANHs { get; set; }
        public virtual DbSet<PHIEUTHU> PHIEUTHUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAILY>()
                .Property(e => e.TENDAILY)
                .IsFixedLength();

            modelBuilder.Entity<GIAI>()
                .HasMany(e => e.KETQUAXOSOes)
                .WithRequired(e => e.GIAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIVESO>()
                .HasMany(e => e.PHATHANHs)
                .WithRequired(e => e.LOAIVESO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHATHANH>()
                .Property(e => e.SOTIENPHAITHANHTOAN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHATHANH>()
                .HasMany(e => e.KETQUAXOSOes)
                .WithRequired(e => e.PHATHANH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUTHU>()
                .Property(e => e.SOTIEN)
                .IsFixedLength();
        }
    }
}
