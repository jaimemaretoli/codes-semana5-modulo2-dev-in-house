using System;

namespace polimorfismo
{

    public class Program
    {
        static void Main(string[] args)
        {
            // Instancia objetos

            // Estagiario
            // Terá acesso aos métodos Vale Transporte e Vale Alimentação
            // Se o Estagiario tiver algum método Vale Transporte ou Vale Alimentação:
            // Irá sobrescrever o método que está em imposto;
            Imposto objetoEstagiario = new Estagiario();
            objetoEstagiario.ValeAlimentacao(1000);
            objetoEstagiario.ValeTransporte(1000);
            Console.WriteLine("------------");

            // Gerente | UpCasting
            Imposto objetoGerente = new Gerente();
            objetoGerente.ValeAlimentacao(5000);
            objetoGerente.ValeTransporte(5000);
            Console.WriteLine("------------");
            
            // Atendente
            Imposto objetoAtendente = new Atendente();
            objetoAtendente.ValeAlimentacao(2000);
            objetoAtendente.ValeTransporte(2000);
            Console.WriteLine("------------");

        }
    }
}