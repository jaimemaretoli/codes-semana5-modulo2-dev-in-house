using System;
namespace exemplo2AulaPolimorfismo
{
	public class Gerente : Imposto
	{
		public Gerente()
		{
		}

        // Métodos

        public void ValeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto gerente do vale alimentação é R$" + salario * 0.15);
        }
    }
}