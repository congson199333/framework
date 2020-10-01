namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class STOnlineShop : DbContext
    {
        public STOnlineShop()
            : base("name=STOnlineShop")
        {
        }

        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Oder> Oders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUser>()
                .Property(e => e.adminName)
                .IsUnicode(false);

            modelBuilder.Entity<AdminUser>()
                .Property(e => e.adminPass)
                .IsUnicode(false);

            modelBuilder.Entity<AdminUser>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.brandName)
                .IsUnicode(false);

            modelBuilder.Entity<Oder>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.productName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.priceSale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.userMail)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.userPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.userAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.payment)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.total)
                .HasPrecision(18, 0);
        }
    }
}
