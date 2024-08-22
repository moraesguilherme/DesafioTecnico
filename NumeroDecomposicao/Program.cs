using NumeroDecomposicao.Models;
using NumeroDecomposicao.Services;

namespace NumeroDecomposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            var divisorService = new DivisorService();
            var primesService = new PrimesService();

            while (true)
            {
                Console.WriteLine("Digite um número:");
                int numero;
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    List<int> divisores = divisorService.ObterDivisores(numero);
                    List<int> divisoresPrimos = primesService.ObterDivisoresPrimos(divisores);

                    var resultado = new DivisorResult(numero, divisores, divisoresPrimos);

                    Console.WriteLine(resultado);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }

                Console.WriteLine("Deseja testar outro número? (s/n)");
                var continuar = Console.ReadLine().ToLower();

                if (continuar != "s")
                {
                    break;
                }
            }

            Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
