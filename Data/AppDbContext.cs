using FundamentosBlazorServer.Models;
using Microsoft.EntityFrameworkCore;

namespace FundamentosBlazorServer.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
}
