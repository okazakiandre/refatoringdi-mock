using RefactoringInjecaoDeDependencia.Dtos;
using RefactoringInjecaoDeDependencia.Repositories;

namespace RefactoringInjecaoDeDependencia.UnitTest
{
    public class ProdutoRepositoryFake : IProdutoRepository
    {
        private ProdutoDto Dto { get; }
        public ProdutoRepositoryFake(ProdutoDto prd)
        {
            Dto = prd;
        }

        public ProdutoDto Obter(int codigo)
        {
            return Dto;
        }
    }
}
