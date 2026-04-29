using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace CSBackEndTest;

public class ArmazemContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    public ArmazemContext(DbContextOptions<ArmazemContext> options)
        : base(options)
    {
    }
}
