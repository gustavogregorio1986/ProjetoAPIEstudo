namespace ProjetoAPIEstudo.request
{
    public class PagamentoRequest
    {
        public int IdPagamento { get; set; }

        public double Preco { get; set; }

        public int Qtde { get; set; }

        public int Parcela { get; set; }

        public ProdutoRequest ProdutoRequest { get; set; }
    }
}
