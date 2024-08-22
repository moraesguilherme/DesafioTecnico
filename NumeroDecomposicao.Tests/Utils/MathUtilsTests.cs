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
        public void EhPrimo_ValidInput_ReturnsExpectedResult(int numero, bool expected)
        {
            // Act
            bool result = MathUtils.EhPrimo(numero);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
