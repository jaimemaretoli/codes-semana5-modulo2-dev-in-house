using System;
namespace exemplo1AulaHerancaPolimorfismo
{
	public class FuncionarioNivel3 : Funcionario
	{

        public int codigo { get; set; }

        public FuncionarioNivel3()
		{
		}

        public FuncionarioNivel3(string nome, char sexo, int codigo) : base(nome, sexo)
        {
            this.codigo = codigo;
        }

        public override double CalcularParticipacaoLucro()
        {
            return base.CalcularParticipacaoLucro() * 0.03;
        }
    }
}