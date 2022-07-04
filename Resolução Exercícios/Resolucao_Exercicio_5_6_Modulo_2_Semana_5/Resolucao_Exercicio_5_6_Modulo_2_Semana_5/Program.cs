using System;
using System.Text.RegularExpressions;

namespace Resolucao_Exercicio_5_6_Modulo_2_Semana_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario objFuncionario = new Funcionario("Jaime", "a1");

            try
            {
                ValidacaoNomeFuncionario(objFuncionario);
                ValidacaoIDFuncionario(objFuncionario);
                VerificaObjetoFuncionarioNull(objFuncionario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro. Mensagem: {ex.Message}");
            }
        }

        public static void VerificaObjetoFuncionarioNull(Funcionario objFuncionario)
        {
            if (objFuncionario == null)
            {
                throw new NullReferenceException("\nO objeto Funcionário está " +
                    "nulo. Informe os valores. \n");
            }

            Console.WriteLine(
                $"\n- O nome do funcionário é: {objFuncionario.nome}\n" +
                $"- O ID é: {objFuncionario.id}\n");
        }


        public static void ValidacaoNomeFuncionario(Funcionario objFuncionario)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(objFuncionario.nome))
            {
                throw new NomeFuncionarioInvalidoException(objFuncionario.nome);
            }
        }

        public static void ValidacaoIDFuncionario(Funcionario objFuncionario)
        {
            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(objFuncionario.id))
            {
                throw new IDFuncionarioInvalidoException(objFuncionario.id);
            }
        }
    }
}