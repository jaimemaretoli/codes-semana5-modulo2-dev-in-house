using System;

namespace extends.Entities
{

	public class ContaPJ : Conta
	{
        public double limiteEmprestimo { get; set; }

        public ContaPJ()
		{

		}

        public ContaPJ(int numero, string nome, double saldoConta, double limiteEmprestimo) : base(numero, nome, saldoConta)
        {
            this.limiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valorEmprestimo)
        {
            if (valorEmprestimo <= limiteEmprestimo)
            {
                saldoConta = +valorEmprestimo;
            }
        }
    }
}