using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        public DbSet<WareHouseEntity> WareHouses { get; set; }

        public DbSet<InOutEntity> InOuts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source=localhost;Initial Catalog=InvetaryBlazor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseos Hogar"},
                new CategoryEntity { CategoryId = "CA1", CategoryName = "Categoria 1" },
                new CategoryEntity { CategoryId = "CA2", CategoryName = "Categoria 2" }
                );

            modelBuilder.Entity<WareHouseEntity>().HasData(
                new WareHouseEntity { WareHouseId=Guid.NewGuid().ToString(), WareHouseName = "Bodega Central", WareHouseAddress = "Calle A"},
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega Primaria", WareHouseAddress = "Calle B" },
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega Secundaria", WareHouseAddress = "Calle C" }
                );
        }
    }
}
