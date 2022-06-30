using System;
namespace exemplo2AulaPolimorfismo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instancia de Objetos
            Imposto objetoEstagiario = new Estagiario();
            objetoEstagiario.ValeAlimentacao(1000);
            objetoEstagiario.ValeTransporte(1000);
            Console.WriteLine("--------------------");

            Imposto objetoGerente = new Gerente();
            objetoGerente.ValeAlimentacao(2000);
            objetoGerente.ValeTransporte(2000);
            Console.WriteLine("--------------------");

            Imposto objetoAtendente = new Atendente();
            objetoAtendente.ValeAlimentacao(1500);
            objetoAtendente.ValeTransporte(1500);
            Console.WriteLine("--------------------");

            // Upcasting implítico
            int a = 1;
            long b = a;
            float c = b;
            double d = c;
            Console.WriteLine(d);

            // Downcasting, explícito
            c = (float)d;
            b = (long)c;
            a = (int)b;
            Console.WriteLine(a);

        }
    }
}