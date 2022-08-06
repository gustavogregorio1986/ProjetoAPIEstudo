using ProjetoAPIEstudo.Data.Contexto;
using ProjetoAPIEstudo.Data.Repository.Interface;
using ProjetoAPIEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPIEstudo.Data.Repository
{
    internal class LoginRepository : ILoginRepository
    {
        private readonly ProjetoAPIEstudoContexto _db;

        public void SalvarLogin(Login login)
        {
            _db.Add(login);
        }
    }
}
