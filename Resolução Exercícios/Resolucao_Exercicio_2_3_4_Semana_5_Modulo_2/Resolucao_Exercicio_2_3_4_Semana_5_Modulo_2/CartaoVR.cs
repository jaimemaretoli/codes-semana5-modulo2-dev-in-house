using System;
namespace Resolucao_Exercicio_2_3_4_Semana_5_Modulo_2
{
	public class CartaoVR : Cartao
	{
		public CartaoVR()
		{
		}

        public CartaoVR(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
        {
        }

        public override double VerificarValorTaxaCartao(double saldo)
        {
            return saldo * 0.05;
        }
    }
}

