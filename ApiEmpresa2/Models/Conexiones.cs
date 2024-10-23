using Microsoft.EntityFrameworkCore;
namespace ApiEmpresa2.Models;
public class Conexiones : DbContext {
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options){
    }

    public DbSet<Clientes> Clientes { get; set; } = null!;
}