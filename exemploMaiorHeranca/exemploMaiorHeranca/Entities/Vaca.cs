using System;
namespace exemploMaiorHeranca.Entities
{
	public class Vaca : Mamifero
    {
        public bool permiteOrdenha { get; set; }

        public Vaca()
        {
        }

        public Vaca(string nome, int velocidade, bool permiteOrdenha) : base(nome, velocidade)
        {
            this.permiteOrdenha = permiteOrdenha;
        }

        public void Ordenhar()
        {
            Console.WriteLine("Ordenhando...");
        }
    }   
}