using System;
namespace exThrowExcecaoManual
{
	public class Estudante
	{
        public string nome { get; set; }
        public int id { get; set; }

        public Estudante()
		{
		}

        public Estudante(string nome, int id)
        {
            this.nome = nome;
            this.id = id;
        }
    }

    [Serializable]
    class NomeEstudanteInvalidoException : Exception
    {
        public NomeEstudanteInvalidoException() { }

        public NomeEstudanteInvalidoException(string nome)
            : base(String.Format($"\nO nome do estudante foi digitado com caracteres inválidos: {nome}.\n"))
        {

        }
    }
}