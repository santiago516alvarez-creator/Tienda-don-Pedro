using System;

namespace Company.ClassLibrary1;

public class AppDbContext : DbContext
{
    public DbSet <Producto> Productos {get ; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder option)

    var connectionString = "Server=localhost;DataBase=TiendadonPedro;User=root;Password=tupass;";
    optionBuilder.UseMysql(connectionString, ServerVersion.AutoDetect(connectionString));
}
