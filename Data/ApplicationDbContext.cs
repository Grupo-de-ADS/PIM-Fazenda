using GerenciamentosCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentosCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
               
        }

        public DbSet<ProdutosModels> Produtos { get; set; }

        public DbSet<FarmModels> Farm { get; set; }

        public DbSet<ShippingModels> Shipping { get; set; }

        public DbSet<CustomerModels> Customer { get; set; }

        public DbSet<TransportModels> Transport { get; set; }

    }

}
