using System;

namespace exemplo1AulaHerancaPolimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario dono = new Funcionario();
            dono.nome = "João";
            Console.WriteLine($"O lucro do João é... {dono.CalcularParticipacaoLucro()}");

            Funcionario nivel1 = new FuncionarioNivel1();
            nivel1.nome = "José";

            Funcionario nivel2 = new FuncionarioNivel2();
            nivel2.nome = "Joana";

            Funcionario nivel3 = new FuncionarioNivel3();
            nivel3.nome = "Willian";

            Console.WriteLine($"Nome do done é: {dono.nome}, teve o lucro de {dono.CalcularParticipacaoLucro()}");

            Console.WriteLine($@"O nome do funcionário nível 1 é {nivel1.nome},
Lucro da Participação foi {nivel1.CalcularParticipacaoLucro().ToString("F2")}

----------------" );

            Console.WriteLine($@"O nome do funcionário nível 1 é {nivel2.nome},
Lucro da Participação foi {nivel2.CalcularParticipacaoLucro().ToString("F2")}

----------------");

            Console.WriteLine($@"O nome do funcionário nível 1 é {nivel3.nome},
Lucro da Participação foi {nivel3.CalcularParticipacaoLucro().ToString("F2")}

----------------");
        }
    }
}