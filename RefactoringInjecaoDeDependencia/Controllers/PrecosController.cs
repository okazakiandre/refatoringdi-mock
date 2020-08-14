using Microsoft.AspNetCore.Mvc;
using RefactoringInjecaoDeDependencia.Repositories;
using System;

namespace RefactoringInjecaoDeDependencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrecosController : ControllerBase
    {
        private IProdutoRepository ProdRepo { get; }
        private ITaxaEntregaRepository TaxaRepo { get; }

        public PrecosController(IProdutoRepository prodRepo, ITaxaEntregaRepository taxaRepo)
        {
            ProdRepo = prodRepo;
            TaxaRepo = taxaRepo;
        }

        [HttpGet("{codigoProduto}")]
        public IActionResult ObterPreco(int codigoProduto, [FromQuery] int cepEntrega)
        {
            var prod = ProdRepo.Obter(codigoProduto);
            if (prod is null)
            {
                return NotFound(new { erro = $"Produto {codigoProduto} nao encontrado" });
            }

            var ret = new ObterPrecoResponse()
            {
                CodigoProduto = prod.Codigo,
                NomeProduto = prod.Nome,
                ValorProduto = prod.Preco,
                PrecoTotal = prod.Preco
            };
            if (prod.TemTaxaEntrega)
            {
                var taxa = TaxaRepo.Obter(cepEntrega);
                ret.ValorEntrega = Math.Round(prod.Preco * taxa.PercentualTaxa, 2);
                ret.PrecoTotal = Math.Round(ret.ValorProduto + ret.ValorEntrega, 2);
            }

            return Ok(ret);
        }
    }
}
