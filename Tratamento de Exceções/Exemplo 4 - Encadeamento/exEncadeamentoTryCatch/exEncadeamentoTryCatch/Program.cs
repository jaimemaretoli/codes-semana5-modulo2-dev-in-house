using System;
namespace exEncadeamentoTryCatch
{
    class Program
    {
        public static void Main(string[] args)
        {

            var divisor = 0;

            try
            {
                try
                {
                    var resultado = 100 / divisor;
                }
                catch
                {
                    Console.WriteLine("Entrou no catch nível 1.");
                }
                finally
                {
                    Console.WriteLine("Entrou no finally nível 1.");
                }
            }
            catch
            {
                Console.WriteLine("Entrou no catch nível 2.");
            }
            finally
            {
                Console.WriteLine("Entrou no finally nível 2.");
            }
        }
    }
}