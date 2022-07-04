using System;
namespace exThrowExcecaoManual
{
	public class Estudante
	{
        public string nome { get; set; }
        public string id { get; set; }

        public Estudante()
		{
		}

        public Estudante(string nome, string id)
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

    [Serializable]
    class IdEstudanteInvalidoException : Exception
    {
        public IdEstudanteInvalidoException() { }

        public IdEstudanteInvalidoException(string id)
            : base(String.Format($"\nO ID informado do estudante foi digitado com caracteres inválidos: {id}.\nSão permitidos apenas números no ID/código."))
        {

        }
    }
}