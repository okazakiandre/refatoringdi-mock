using RefactoringInjecaoDeDependencia.Dtos;
using System.Collections.Generic;

namespace RefactoringInjecaoDeDependencia.Repositories
{
    public class TaxaEntregaRepository : ITaxaEntregaRepository
    {
        private List<TaxaEntregaDto> ListaTaxas { get; }
        public TaxaEntregaRepository()
        {
            ListaTaxas = new List<TaxaEntregaDto>()
            {
                new TaxaEntregaDto(1, 9999999, 0.05m),
                new TaxaEntregaDto(10000000, 39999999, 0.07m),
                new TaxaEntregaDto(40000000, 69999999, 0.02m),
                new TaxaEntregaDto(70000000, 99999999, 0.03m)
            };
        }

        public TaxaEntregaDto Obter(int cep)
        {
            return ListaTaxas.Find(p => p.CepInicio <= cep && p.CepFim >= cep);
        }
    }
}
