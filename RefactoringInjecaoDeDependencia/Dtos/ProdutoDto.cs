namespace RefactoringInjecaoDeDependencia.Dtos
{
    public class ProdutoDto
    {
        public ProdutoDto(int codigo, string nome, decimal preco, bool temTaxa)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            TemTaxaEntrega = temTaxa;
        }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool TemTaxaEntrega { get; set; }
    }
}
