using Microsoft.EntityFrameworkCore;
using ProjetoAPIEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPIEstudo.Data.Contexto
{
    public class ProjetoAPIEstudoContexto : DbContext
    {
        public ProjetoAPIEstudoContexto(DbContextOptions option)
            : base(option)
        {

        }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Loja> Lojas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
