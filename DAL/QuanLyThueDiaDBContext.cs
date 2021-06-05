using Entities;
using System.Data.Entity;

namespace DAL
{
    public class QuanLyThueDiaDBContext : DbContext
    {
        public QuanLyThueDiaDBContext() : base("QLTDDBContext")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DetailPreOrder> DetailPreOrders { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<DiskType> DiskTypes { get; set; }
        public DbSet<ListRented> ListRenteds { get; set; }
        public DbSet<ListTitlePreOrder> ListTitlePreOrders { get; set; }
        public DbSet<Title> Titles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
