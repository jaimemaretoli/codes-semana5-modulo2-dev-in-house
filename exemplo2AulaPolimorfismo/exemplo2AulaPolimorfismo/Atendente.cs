using System;
namespace exemplo2AulaPolimorfismo
{
	public class Atendente : Imposto
	{
		public Atendente()
		{
		}

        // Métodos

        public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto atendente do vale alimentação é R$" + salario * 0.12);
        }
    }
}

