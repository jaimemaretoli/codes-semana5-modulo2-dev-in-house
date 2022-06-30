using System;
namespace exemplo1AulaHerancaPolimorfismo
{
	public class FuncionarioNivel1 : Funcionario
	{

        public int idade { get; set; }

        public FuncionarioNivel1()
		{
		}

        public FuncionarioNivel1(string nome, char sexo, int idade) : base(nome, sexo)
        {
            this.idade = idade;
        }

        public double CalcularParticipacaoLucro()
        {
            return base.CalcularParticipacaoLucro() * 0.01;
        }

        public void CalcularImposto()
        {
            Console.WriteLine("Qualquer coisa");
        }
    }
}

