using AppVendasWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AppVendasWeb.Data
{
	public class AppVendasContext : DbContext
	{
		public AppVendasContext(DbContextOptions<AppVendasContext> options) : base(options) { }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Produto> Produtos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cliente>().ToTable("Cliente"); //responsavel por criar as tabelas | meio de campo esqueça
			modelBuilder.Entity<Categoria>().ToTable("Categorias");
			modelBuilder.Entity<Produto>().ToTable("Produtos");
		}
	}
}
