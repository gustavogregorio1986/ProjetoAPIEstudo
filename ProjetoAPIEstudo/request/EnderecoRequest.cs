namespace ProjetoAPIEstudo.request
{
    public class EnderecoRequest
    {
        public int IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public UsuarioRequest UsuarioRequest { get; set; }
    }
}
