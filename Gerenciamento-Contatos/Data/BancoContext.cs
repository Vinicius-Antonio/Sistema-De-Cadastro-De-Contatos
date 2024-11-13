using Microsoft.EntityFrameworkCore;
using ControleDeContatos.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { } 
        public DbSet<Contato> Contatos { get; set; }
    }
}