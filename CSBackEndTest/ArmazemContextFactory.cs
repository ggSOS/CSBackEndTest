using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace CSBackEndTest;

public class ArmazemContextFactory : IDesignTimeDbContextFactory<ArmazemContext>
{
    public ArmazemContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();
        var conexao = ConnectionHelper.GetConnectionString(config);
        
        var optionsBuilder = new DbContextOptionsBuilder<ArmazemContext>();
        optionsBuilder.UseMySql(
            conexao,
            ServerVersion.AutoDetect(conexao));

        return new ArmazemContext(optionsBuilder.Options);
    }
}
