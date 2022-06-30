using System;

namespace extends.Entities
{
	public class Conta
	{
        public int numero { get; set; }
        public string nome { get; set; }
        public double saldoConta { get; set; }

        public Conta()
		{
		}

        public Conta(int numero, string nome, double saldoConta)
        {
            this.numero = numero;
            this.nome = nome;
            this.saldoConta = saldoConta;
        }

        public void Saque(double valor)
        {
            saldoConta -= valor;
        }

        public void Deposito(double valor)
        {
            saldoConta += valor;
        }
    }
}