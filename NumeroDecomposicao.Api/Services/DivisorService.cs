namespace NumeroDecomposicao.Api.Services
{
    public class DivisorService
    {
        public List<int> ObterDivisores(int numero)
        {
            if (numero <= 0)
                throw new ArgumentException("O número deve ser maior que zero.", nameof(numero));

            List<int> divisores = new List<int>();

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores.Add(i);
                }
            }

            return divisores;
        }
    }
}
