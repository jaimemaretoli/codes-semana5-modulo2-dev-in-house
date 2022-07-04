using System;
namespace Resolucao_Exercicio_5_6_Modulo_2_Semana_5
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string id { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, string id)
        {
            this.nome = nome;
            this.id = id;
        }
    }

    class NomeFuncionarioInvalidoException : Exception
    {
        public NomeFuncionarioInvalidoException() { }

        public NomeFuncionarioInvalidoException(string nome)
            : base(String.Format(
                $"\nO nome do funcionário foi digitado com " +
                $"caracteres inválidos: {nome}. Favor informar somente letras" +
                $" para nomes."))
        {

        }
    }

    class IDFuncionarioInvalidoException : Exception
    {
        public IDFuncionarioInvalidoException() { }

        public IDFuncionarioInvalidoException(string id)
            : base(String.Format(
                $"\nO ID do funcionário foi digitado com " +
                $"caracteres inválidos: {id}. Favor informar somente números" +
                $" para o ID."))
        {

        }
    }
}

