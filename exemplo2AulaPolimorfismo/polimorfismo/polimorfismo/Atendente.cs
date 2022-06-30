using System;
namespace polimorfismo
{
	public class Atendente : Imposto
	{
		public Atendente()
		{
		}

		// Métodos
		public override void ValeAlimentacao(double salario)
		{
			// Desconto de 12% ao atendente
			Console.WriteLine("Desconto atendente do vale alimentação R$ " + salario * 0.12);
		}
	}
}

