using System;

namespace exemploMaiorHeranca.Entities
{
    public class Cachorro : Mamifero
    {
        public bool tipoLatido { get; set; }

        public Cachorro(string nome, int velocidade, bool tipoLatido) : base(nome, velocidade)
        {
            this.tipoLatido = tipoLatido;
        }

        public Cachorro()
        {
        }

        public void LevarAoPet()
        {
            Console.WriteLine("Indo ao pet...");
        }
    }
}