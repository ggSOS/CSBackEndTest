using System;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace CSBackEndTest;

public abstract class ConnectionHelper
{
    public static string GetConnectionString(IConfiguration config)
    {
        var builder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            Port = uint.Parse(config["DbPort"]!),
            Database = config["DbName"],
            UserID = config["DbUser"],
            Password = config["DbPassword"]
        };

        return builder.ConnectionString;
    }
}
