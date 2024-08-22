using Microsoft.AspNetCore.Mvc;
using NumeroDecomposicao.Api.Models;
using NumeroDecomposicao.Api.Services;

namespace NumeroDecomposicao.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DivisorController : ControllerBase
    {
        private readonly DivisorService _divisorService;
        private readonly PrimesService _primesService;

        public DivisorController(DivisorService divisorService, PrimesService primesService)
        {
            _divisorService = divisorService;
            _primesService = primesService;
        }

        [HttpGet("divisores/{numero}")]
        public ActionResult<DivisorResult> GetDivisores(int numero)
        {
            if (numero <= 0)
            {
                return BadRequest("O número deve ser maior que zero.");
            }

            var divisores = _divisorService.ObterDivisores(numero);
            var divisoresPrimos = _primesService.ObterDivisoresPrimos(divisores);

            var resultado = new DivisorResult(numero, divisores, divisoresPrimos);
            return Ok(resultado);
        }
    }
}
