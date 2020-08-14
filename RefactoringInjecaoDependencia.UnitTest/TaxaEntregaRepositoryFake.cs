using RefactoringInjecaoDeDependencia.Dtos;
using RefactoringInjecaoDeDependencia.Repositories;

namespace RefactoringInjecaoDeDependencia.UnitTest
{
    public class TaxaEntregaRepositoryFake : ITaxaEntregaRepository
    {
        public TaxaEntregaDto Obter(int cep)
        {
            return new TaxaEntregaDto(70000000, 99999999, 0.03m);
        }
    }
}
