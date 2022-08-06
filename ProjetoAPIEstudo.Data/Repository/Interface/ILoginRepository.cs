using ProjetoAPIEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPIEstudo.Data.Repository.Interface
{
    public interface ILoginRepository
    {
        void SalvarLogin(Login login);
    }
}
