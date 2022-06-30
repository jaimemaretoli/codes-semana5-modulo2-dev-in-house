using System;
namespace exemplo1AulaHerancaPolimorfismo
{
	public class Funcionario
	{
        public string nome { get; set; }

        public char sexo { get; set; }

        public Funcionario()
		{
		}

        public Funcionario(string nome, char sexo)
        {
            this.nome = nome;
            this.sexo = sexo;
        }

        // método virtual, permitir polimorfismo nas sub-classes
        public virtual double CalcularParticipacaoLucro()
        {
            return 1000;
        }
    }
}

