using System;

namespace extends.Entities
{
	public class Program
	{
		static void Main()
		{

            // Instância de dois objetos
            Conta conta1 = new Conta(1001, "Jaime", 0.0);
            ContaPJ contaPJ1 = new ContaPJ(1002, "Roberto", 0.0, 500.0);

            // UPCASTING, conversão da subclasse para a superclass

            // Exemplo 1:

            Conta contaUp = contaPJ1;

            Console.WriteLine(contaUp.nome);

            // Exemplo 2:

            Conta contaUp2 = new ContaPJ(1003, "Bruno", 0.0, 200.00);

            Console.WriteLine(contaUp2.nome);

            Conta contaUp3 = new ContaPoupanca(1004, "Alexandre", 0.0, 50.0);

            Console.WriteLine(contaUp3.nome);

            Console.WriteLine(contaUp2.saldoConta);

            // ############## // ############## // ############## // ##############
            //// Downcasting, conversão da superclasse em subclasse;

            // entre parênteses, o tipo de destino.
            ContaPJ contaDown4 = (ContaPJ)contaUp2;

            contaDown4.Emprestimo(100.00);
            Console.WriteLine(contaDown4.saldoConta);

            ContaPJ contaUp5 = (ContaPJ)contaUp3;

            if (contaUp3 is ContaPJ)
            {
                //ContaPJ contaUp5 = (ContaPJ)contaUp3;
                ContaPJ contaUp5 = contaUp3 as ContaPJ;
                contaUp5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo Realizado!");
            }

            if (contaUp3 is ContaPoupanca)
            {
                // ContaPoupanca contaUp5 = (ContaPoupanca)contaUp3; // Downcasting
                ContaPoupanca contaUp5 = contaUp3 as ContaPoupanca;
                contaUp5.AtualizarSaldo();
                Console.WriteLine("Atualizado com Sucesso");
            }


            // ############################################

            //ContaPJ contaPessoaJuridica = new ContaPJ(8010, "Jaime", 100.0, 500.0);

            //Console.WriteLine(contaPessoaJuridica.saldoConta);

            ////contaPessoaJuridica.saldoConta += 100.0;
            //contaPessoaJuridica.Emprestimo(100);

            //contaPessoaJuridica.Saque(50);

            //Console.WriteLine(contaPessoaJuridica.saldoConta);

        }
    }
}
