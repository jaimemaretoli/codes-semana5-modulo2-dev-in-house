using System;
namespace Resolucao_Exercicio_2_3_4_Semana_5_Modulo_2
{
	public class CartaoVA : Cartao
	{
		public CartaoVA()
		{
		}

        public CartaoVA(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
        {
        }

        public override double VerificarValorTaxaCartao(double saldo)
        {
            return saldo * 0.10;
        }
    }
}

