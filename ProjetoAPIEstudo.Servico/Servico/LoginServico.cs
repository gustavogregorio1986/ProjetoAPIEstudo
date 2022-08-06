using ProjetoAPIEstudo.Data.Repository.Interface;
using ProjetoAPIEstudo.Dominio.Dominio;
using ProjetoAPIEstudo.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPIEstudo.Servico.Servico
{
    public class LoginServico : ILoginServico
    {
        private readonly ILoginRepository _repositorio;

        public LoginServico(ILoginRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void SalvarLogin(Login login)
        {
            _repositorio.SalvarLogin(login);
        }
    }
}
