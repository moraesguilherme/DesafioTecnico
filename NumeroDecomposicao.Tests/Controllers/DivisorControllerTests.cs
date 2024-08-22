using Microsoft.AspNetCore.Mvc;
using NumeroDecomposicao.Api.Controllers;
using NumeroDecomposicao.Api.Models;
using NumeroDecomposicao.Api.Services;

namespace NumeroDecomposicao.Tests.Controllers
{
    public class DivisorControllerTests
    {
        private readonly DivisorController _controller;

        public DivisorControllerTests()
        {
            var divisorService = new DivisorService();
            var primesService = new PrimesService();
            _controller = new DivisorController(divisorService, primesService);
        }

        [Fact]
        public void Deve_RetornarDivisoresEPrimos_QuandoNumeroValido()
        {
            int numero = 45;

            var result = _controller.GetDivisores(numero);

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var divisorResult = Assert.IsType<DivisorResult>(okResult.Value);

            Assert.Equal(45, divisorResult.Numero);
            Assert.Equal(new List<int> { 1, 3, 5, 9, 15, 45 }, divisorResult.Divisores);
            Assert.Equal(new List<int> { 3, 5 }, divisorResult.DivisoresPrimos);
        }

        [Fact]
        public void Deve_RetornarBadRequest_QuandoNumeroInvalido()
        {
            var result = _controller.GetDivisores(0);

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result.Result);
            Assert.Equal("O número deve ser maior que zero.", badRequestResult.Value);
        }
    }
}
