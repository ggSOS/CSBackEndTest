//todo secrets
using CSBackEndTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

var conexao = ConnectionHelper.GetConnectionString(config);

var services = new ServiceCollection();

services.AddDbContext<ArmazemContext>(options =>
    options.UseMySql(
        conexao,
        ServerVersion.AutoDetect(conexao)));

var provider = services.BuildServiceProvider();

using var context = provider.GetRequiredService<ArmazemContext>();

while (true)
{
    
}