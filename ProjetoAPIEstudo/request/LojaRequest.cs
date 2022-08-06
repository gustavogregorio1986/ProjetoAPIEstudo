namespace ProjetoAPIEstudo.request
{
    public class LojaRequest
    {
        public int IdLoja { get; set; }

        public string NomeLoja { get; set; }

        public UsuarioRequest UsuarioRequest { get; set; }
    }
}
