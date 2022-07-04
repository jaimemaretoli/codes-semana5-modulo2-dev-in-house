using System;
using System.Text.RegularExpressions;

namespace exThrowExcecaoManual
{
    class Program
    {
        public static void Main(string[] args)
        {
            Estudante objetoEstudante = new Estudante("Joao", "1-"); // null, para gerar a exception

            try
            {
                ValidacaoEstudante(objetoEstudante);
                MostrarNomeEstudante(objetoEstudante);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void MostrarNomeEstudante(Estudante objetoEstudante)
        {
            if (objetoEstudante == null)
            {
                throw new NullReferenceException("\nO objeto Estudante é nulo. Informe os valores.\n");
            }

            Console.WriteLine(
                $"\n- O nome do estudante é: {objetoEstudante.nome}.\n" +
                $"- O código deste estudante é {objetoEstudante.id}.\n");
        }

        public static void ValidacaoEstudante(Estudante objetoEstudante)
        {
            Regex regexLetras = new Regex("^[a-zA-Z]+$");
            Regex regexNumeros = new Regex("^[0-9]+$");

            if (!regexLetras.IsMatch(objetoEstudante.nome))
            {
                throw new NomeEstudanteInvalidoException(objetoEstudante.nome);
            }

            if (!regexNumeros.IsMatch(objetoEstudante.id))
            {
                throw new IdEstudanteInvalidoException(objetoEstudante.id);
            }
        }
    }
}