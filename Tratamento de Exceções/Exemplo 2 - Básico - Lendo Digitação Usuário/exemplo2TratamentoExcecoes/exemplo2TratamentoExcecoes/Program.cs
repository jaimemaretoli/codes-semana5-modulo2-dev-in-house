using System;

namespace exemplo2TratamentoExcecoes
{
    class Program
    {
        // método principal
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número: ");

                var numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"O resultado de {numero} x {numero} é: {numero * numero}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro. A mensagem do erro é: {ex}\n");
            }
            finally
            {
                Console.WriteLine("Digite um número, novamente. Por gentileza.");
            }
        }
    }
}