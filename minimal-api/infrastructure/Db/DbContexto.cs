using Microsoft.EntityFrameworkCore;
using Minimal_api.Dominio.Entidades;

namespace Minimal_api.infrastructure.Db;

public class DbContexto : DbContext
{
  public DbSet<Administrador> Administradores { get; set; } = default!;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseMySql("string de conexao", ServerVersion.AutoDetect("String de conexao"));
  }
}