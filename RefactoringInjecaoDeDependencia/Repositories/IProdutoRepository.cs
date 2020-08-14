using RefactoringInjecaoDeDependencia.Dtos;

namespace RefactoringInjecaoDeDependencia.Repositories
{
    public interface IProdutoRepository
    {
        ProdutoDto Obter(int codigo);
    }
}
