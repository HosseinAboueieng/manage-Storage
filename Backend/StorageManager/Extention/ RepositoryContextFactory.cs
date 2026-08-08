using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace StorageManager.Extention;

public class  RepositoryContextFactory:IDesignTimeDbContextFactory<RepositoryContex> 
{
    public RepositoryContex CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder() 
        .SetBasePath(Directory.GetCurrentDirectory()) 
        .AddJsonFile("appsettings.json").Build();
        var builder = new DbContextOptionsBuilder<RepositoryContex>() 
        .UseSqlServer(configuration.GetConnectionString("sqlConnection")
        ,b=>b.MigrationsAssembly("StorageManager")); 
        return new RepositoryContex(builder.Options);
    }
}

