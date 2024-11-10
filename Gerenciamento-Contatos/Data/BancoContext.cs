using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) : base(Options)
        {  
        }

        public Dbset<ContatoModel> Contatos {get; set; }   
    }
}