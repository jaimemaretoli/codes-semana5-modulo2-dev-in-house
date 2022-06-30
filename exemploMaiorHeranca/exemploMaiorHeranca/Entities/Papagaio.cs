using System;
namespace exemploMaiorHeranca.Entities
{
	public class Papagaio : Ave
	{
        public string vocabulario { get; set; }

        public Papagaio()
		{
		}

		public Papagaio(string nome, string tipoVoo, string vocabulario) : base(nome, tipoVoo)
		{
			this.vocabulario = vocabulario;
		}
	}
}

