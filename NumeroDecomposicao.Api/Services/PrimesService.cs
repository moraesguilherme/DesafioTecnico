using NumeroDecomposicao.Api.Utils;

namespace NumeroDecomposicao.Api.Services
{
    public class PrimesService
    {
        public List<int> ObterDivisoresPrimos(List<int> divisores)
        {
            if (divisores == null || !divisores.Any())
                throw new ArgumentException("A lista de divisores não pode estar vazia.", nameof(divisores));

            return divisores.Where(MathUtils.EhPrimo).ToList();
        }
    }
}
