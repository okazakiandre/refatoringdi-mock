namespace RefactoringInjecaoDeDependencia.Dtos
{
    public class TaxaEntregaDto
    {
        public TaxaEntregaDto(int cepIni, int cepFim, decimal taxa)
        {
            CepInicio = cepIni;
            CepFim = cepFim;
            PercentualTaxa = taxa;
        }
        public int CepInicio { get; set; }
        public int CepFim { get; set; }
        public decimal PercentualTaxa { get; set; }
    }
}
