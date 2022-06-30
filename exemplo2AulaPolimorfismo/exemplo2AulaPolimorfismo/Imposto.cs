using System;
namespace exemplo2AulaPolimorfismo
{
	public class Imposto
	{
		public Imposto()
		{
		}

		// Métodos

		public virtual void ValeAlimentacao(double salario)
		{
			// Descontando 10% do salario bruto do colaborador
			Console.WriteLine("Desconto padrão do vale alimentação é R$ " + salario * 0.1);
		}

		public virtual void ValeTransporte(double salario)
		{
			// Descontando 6% do salario bruto do colaborador
			Console.WriteLine("Desconto padrão do vale transporte é R$ " + salario * 0.06);
		}
	}
}

