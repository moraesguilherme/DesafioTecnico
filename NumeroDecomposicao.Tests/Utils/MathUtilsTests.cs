using NumeroDecomposicao.Api.Utils;

namespace NumeroDecomposicao.Tests.Utils
{
    public class MathUtilsTests
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(17, true)]
        public void Deve_RetornarSeEhPrimo_QuandoEntradaValida(int numero, bool expected)
        {
            bool result = MathUtils.EhPrimo(numero);

            Assert.Equal(expected, result);
        }
    }
}
