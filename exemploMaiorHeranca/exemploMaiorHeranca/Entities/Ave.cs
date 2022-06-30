using System;
namespace exemploMaiorHeranca.Entities
{
	public class Ave : Animal
	{

        public string tipoVoo { get; set; }

        public Ave()
		{
		}

        public Ave(string nome, string tipoVoo) : base(nome)
        {
            this.tipoVoo = tipoVoo;
        }

        public void Voar(int altura) {
            Console.WriteLine($"A ave está voande em {altura}");
        }
    }
}