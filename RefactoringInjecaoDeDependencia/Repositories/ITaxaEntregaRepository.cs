using RefactoringInjecaoDeDependencia.Dtos;

namespace RefactoringInjecaoDeDependencia.Repositories
{
    public interface ITaxaEntregaRepository
    {
        TaxaEntregaDto Obter(int cep);
    }
}
