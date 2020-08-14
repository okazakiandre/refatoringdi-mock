using RefactoringInjecaoDeDependencia.Dtos;
using System.Collections.Generic;

namespace RefactoringInjecaoDeDependencia.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private List<ProdutoDto> ListaProdutos { get; }
        public ProdutoRepository()
        {
            ListaProdutos = new List<ProdutoDto>()
            {
                new ProdutoDto(1, "TV 75 polegadas", 7044.75m, true),
                new ProdutoDto(2, "Celular super novo", 4976.00m, false),
                new ProdutoDto(3, "Notebook superfino", 6777.99m, true),
                new ProdutoDto(4, "Roteador wifi", 133.29m, false)
            };
        }

        public ProdutoDto Obter(int codigo)
        {
            return ListaProdutos.Find(p => p.Codigo == codigo);
        }
    }
}
