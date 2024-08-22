using NumeroDecomposicao.Api.Services;

namespace NumeroDecomposicao.Tests.Services
{
    public class PrimesServiceTests
    {
        private readonly PrimesService _primesService;

        public PrimesServiceTests()
        {
            _primesService = new PrimesService();
        }

        [Fact]
        public void ObterDivisoresPrimos_ValidDivisors_ReturnsCorrectPrimeDivisors()
        {
            List<int> divisores = new List<int> { 1, 3, 5, 9, 15, 45 };

            List<int> result = _primesService.ObterDivisoresPrimos(divisores);

            Assert.Equal(new List<int> { 3, 5 }, result);
        }

        [Fact]
        public void ObterDivisoresPrimos_NullDivisors_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _primesService.ObterDivisoresPrimos(null));
        }
    }
}
