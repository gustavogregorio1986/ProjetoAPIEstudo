using ProjetoAPIEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPIEstudo.Servico.Servico.Interface
{
    public interface ILoginServico
    {
        void SalvarLogin(Login login);
    }
}
