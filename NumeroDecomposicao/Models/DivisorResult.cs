namespace NumeroDecomposicao.Models
{
    public class DivisorResult
    {
        public int Numero { get; set; }

        public List<int> Divisores { get; set; }

        public List<int> DivisoresPrimos { get; set; }

        public DivisorResult(int numero, List<int> divisores, List<int> divisoresPrimos)
        {
            Numero = numero;
            Divisores = divisores;
            DivisoresPrimos = divisoresPrimos;
        }

        public override string ToString()
        {
            return $"Número de Entrada: {Numero}\n" +
                   $"Números divisores: {string.Join(" ", Divisores)}\n" +
                   $"Divisores Primos: {string.Join(" ", DivisoresPrimos)}";
        }
    }
}
