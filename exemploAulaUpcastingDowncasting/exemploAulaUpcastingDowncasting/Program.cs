using System;

namespace exemploAulaUpcastingDowncasting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Upcasting
            //Forma circuloUp = new Circulo();

            //Circulo circuloUpOutraManeira = new Circulo();
            //Forma objetoForma = circuloUpOutraManeira;

            //objetoForma.Desenhar();
            //Console.WriteLine(objetoForma == circuloUpOutraManeira);

            //// Downcasting explícito
            //Circulo circuloDowncasting = (Circulo)objetoForma;
            //circuloDowncasting.Desenhar();
            //circuloDowncasting.PintarCirculo();

            //Console.WriteLine(circuloDowncasting == objetoForma);
            //Console.WriteLine(circuloDowncasting == circuloUpOutraManeira);

            // ----------- Parte 2 ----------------

            // Upcasting
            Circulo circulo = new Circulo();
            Forma forma = circulo;

            //Forma formaPura = new Forma();

            forma.Desenhar();

            if (forma is Circulo) // verificar se é possível o Downcasting
            {
                Circulo circuloDowncasting = (Circulo)forma;
                circuloDowncasting.PintarCirculo();
            }
            else
            {
                Console.WriteLine("Operação Inválida");
            }
        }
    }
}