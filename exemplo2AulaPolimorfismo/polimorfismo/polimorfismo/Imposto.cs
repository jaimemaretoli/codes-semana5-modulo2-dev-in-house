using System;
namespace polimorfismo
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
            Console.WriteLine("Desconto padrão do vale alimentação R$ " + salario * 0.1);
		}

		public void ValeTransporte(double salario)
		{
			// Descontando 6% do salario bruto do colaborador
			Console.WriteLine("Desconto padrão do vale transporte R$ " + salario * 0.06);
		}
	}
}

