using System;
namespace Resolucao_Exercicio_2_3_4_Semana_5_Modulo_2
{
	public class CartaoVT : Cartao
	{
		public CartaoVT()
		{
		}

        public CartaoVT(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
        {
        }

        public override double VerificarValorTaxaCartao(double saldo)
        {
            return saldo * 0.01;
        }
    }
}

