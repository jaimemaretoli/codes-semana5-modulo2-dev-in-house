using System;

namespace exCriarArquivoEGravarTexto
{
    class Program
    {
        public static void Main(string[] args)
        {

            FileInfo arquivo = null;

            try
            {
                Console.WriteLine("Digite o nome do arquivo para escrever: ");
                string nomeArquivo = Console.ReadLine();
                arquivo = new FileInfo(nomeArquivo);

                using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
                {
                    gravadorFluxo.WriteLine("Texto gravado dentro do arquivo.");
                }

                using (StreamReader leitorArquivo = File.OpenText(nomeArquivo))
                {
                    string s = "";
                    while ((s = leitorArquivo.ReadLine()) != null)
                    {
                        Console.WriteLine($"Lendo o arquivo...\n {s}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro. Mensagem do erro é: {ex}");
            }
            finally
            {
                Console.WriteLine($"Encerrando o programa...");
                arquivo = null;
            }
        }
    }
}