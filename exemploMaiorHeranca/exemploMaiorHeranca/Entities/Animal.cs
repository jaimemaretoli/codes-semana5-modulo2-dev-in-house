using System;


namespace exemploMaiorHeranca.Entities
{
	public class Animal
	{
		public string nome { get; set; }

        public Animal()
        {
        }

        public Animal(string nome)
        {
            this.nome = nome;
        }

        public void Imprime()
        {
            Console.WriteLine("Imprimiu");
        }

        public void Falar(string tipo)
        {
            Console.WriteLine(tipo);
        }
    }
}

