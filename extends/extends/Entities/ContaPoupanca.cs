using System;

namespace extends.Entities
{
	public class ContaPoupanca : Conta
	{

        public double taxaJuros { get; set; }

        public ContaPoupanca()
		{    

		}

		public ContaPoupanca(int numero, string nome, double saldoConta, double taxaJuros)
			: base(numero, nome, saldoConta)
		{
			this.taxaJuros = taxaJuros;
		}

		public void AtualizarSaldo()
		{
			saldoConta += saldoConta * taxaJuros;
		}
	}
}

