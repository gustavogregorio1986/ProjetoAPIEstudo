namespace ProjetoAPIEstudo.request
{
    public class ProdutoRequest
    {
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public UsuarioRequest UsuarioRequest { get; set; }
    }
}
