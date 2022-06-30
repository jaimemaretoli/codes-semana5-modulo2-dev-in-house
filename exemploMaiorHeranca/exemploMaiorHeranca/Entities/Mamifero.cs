using System;
namespace exemploMaiorHeranca.Entities
{
	public class Mamifero : Animal
	{
        public int velocidade { get; set; }

        public Mamifero()
		{
		}

        public Mamifero(string nome, int velocidade) : base(nome)
        {
            this.velocidade = velocidade;
        }

        public void Correr()
        {
            Console.WriteLine("Correu");
        }
    }
}