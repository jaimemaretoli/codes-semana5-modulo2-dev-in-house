using System;
namespace polimorfismo
{
	public class Gerente : Imposto
	{
		public Gerente()
		{
		}

		// Métodos
		public override void ValeAlimentacao(double salario)
		{
			// Desconto de 15% ao gerente
			Console.WriteLine("Desconto gerente do vale alimentação R$ " + salario * 0.15);
		}
	}
}

