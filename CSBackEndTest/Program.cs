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

void MySqlInsert()
{
    try
    {
        string nomeProduto = "asdasd";
        float precoProduto = 6.9F;
        int quantidadeProduto = 20;

        Produto produto = new Produto
        {
            Nome = nomeProduto,
            Preco = precoProduto,
            Quantidade = quantidadeProduto
        };
        context.Produtos.Add(produto);
        context.SaveChanges();

        System.Console.WriteLine("> Produto salvo com sucesso!");
    }
    catch (System.Exception e)
    {
        Console.WriteLine($"> Falha ao salvar Produto:\n{e.Message}");
    }

}

while (true)
{

}