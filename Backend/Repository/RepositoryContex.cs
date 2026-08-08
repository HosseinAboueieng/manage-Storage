using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContex:DbContext
{
    public RepositoryContex(DbContextOptions options)
    :base(options)
    {
        
    }
    public DbSet<Products> products { get; set; }
    public DbSet<Distributer> distributers { get; set; }
    public DbSet<GroupOfProduct> groupOfProducts { get; set; }
    public DbSet<Storage> storages  { get; set; }
    public DbSet<BuyFactor> factors  { get; set; }
}
