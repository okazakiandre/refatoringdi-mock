namespace RefactoringInjecaoDeDependencia.Controllers
{
    public class ObterPrecoResponse
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoTotal { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal ValorEntrega { get; set; }
    }
}
