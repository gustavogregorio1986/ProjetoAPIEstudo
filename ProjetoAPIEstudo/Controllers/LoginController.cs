using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPIEstudo.Dominio.Dominio;

namespace ProjetoAPIEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServico _servico;

        [HttpPost]
        public JsonResult Salvar(Login login)
        {
            return new JsonResult(login);
        }
    }
}
