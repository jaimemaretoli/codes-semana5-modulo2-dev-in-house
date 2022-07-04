﻿using System;
namespace Resolucao_Exercicio_2_3_4_Semana_5_Modulo_2
{
	public class Cartao
	{

        public string bandeira { get; set; }
        public double saldo { get; set; }
        public double valorTaxa { get; set; }

        public Cartao()
		{
		}

        public Cartao(string bandeira, double saldo, double valorTaxa)
        {
            this.bandeira = bandeira;
            this.saldo = saldo;
            this.valorTaxa = valorTaxa;
        }

        public virtual double VerificarValorTaxaCartao(double saldo)
        {
            return saldo * 0.02;
        }
    }
}

