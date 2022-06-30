using System;
namespace exemplo1AulaHerancaPolimorfismo
{
	public class FuncionarioNivel2 : Funcionario
	{

        public string cargo { get; set; }

        public FuncionarioNivel2()
		{
		}

        public FuncionarioNivel2(string nome, char sexo, string cargo) : base(nome, sexo)
        {
            this.cargo = cargo;
        }

        public override double CalcularParticipacaoLucro()
        {
            return base.CalcularParticipacaoLucro() * 0.02;
        }
    }
}