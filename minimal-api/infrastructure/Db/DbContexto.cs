using Microsoft.EntityFrameworkCore;
using Minimal_api.Dominio.Entidades;

namespace Minimal_api.infrastructure.Db;

public class DbContexto : DbContext
{
  private readonly IConfiguration _configuracaoAppSettings;

  public DbContexto(IConfiguration configuracaoAppSettings)
  {
    _configuracaoAppSettings = configuracaoAppSettings;
  }

  public DbSet<Administrador> Administradores { get; set; } = default!;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();

    if (!string.IsNullOrEmpty(stringConexao))
    {
      optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

  }
}