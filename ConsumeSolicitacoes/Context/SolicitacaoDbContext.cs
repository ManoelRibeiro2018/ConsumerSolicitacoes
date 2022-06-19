using ConsumeSolicitacoes.Dto;
using ConsumeSolicitacoes.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ConsumeSolicitacoes.Context
{
    public class SolicitacaoDbContext : DbContext
    {
        public SolicitacaoDbContext(DbContextOptions<SolicitacaoDbContext> options) : base(options) { }
        public DbSet<SolicitacaoModel> SolicitacaoModels { get; set; }
        public DbSet<SolicitacaoViewModel> SolicitacaoViews { get; set; }
        public DbSet<SocilitacaoByYearViewModel> SocilitacaoByYearViewModels { get; set; }
        public DbSet<SolicitacaoByMonthViewModel> SolicitacaoByMonthViewModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
