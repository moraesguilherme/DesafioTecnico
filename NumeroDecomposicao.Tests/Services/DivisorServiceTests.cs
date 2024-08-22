using NumeroDecomposicao.Api.Services;

namespace NumeroDecomposicao.Tests.Services
{
    public class DivisorServiceTests
    {
        private readonly DivisorService _divisorService;

        public DivisorServiceTests()
        {
            _divisorService = new DivisorService();
        }

        [Fact]
        public void Deve_RetornarDivisoresCorretos_QuandoNumeroValido()
        {
            int numero = 45;

            List<int> result = _divisorService.ObterDivisores(numero);

            Assert.Equal(new List<int> { 1, 3, 5, 9, 15, 45 }, result);
        }

        [Fact]
        public void Deve_LancarArgumentException_QuandoNumeroForZero()
        {
            int numero = 0;

            Assert.Throws<ArgumentException>(() => _divisorService.ObterDivisores(numero));
        }
    }
}
