namespace ProjetoAPIEstudo.request
{
    public class UsuarioRequest
    {
        public int IdUsuario { get; set; }

        public string No0meUsuario { get; set; }

        public string Sexo { get; set; }

        public string Cpf { get; set; }

        public LoginRequest LoginRequest { get; set; }
    }
}
