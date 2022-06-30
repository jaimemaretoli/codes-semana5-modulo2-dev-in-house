using System;
namespace exemploAulaUpcastingDowncasting
{
	public class Quadrado : Forma 
	{
		public Quadrado()
		{
		}

		public override void Desenhar()
		{
			Console.WriteLine("Desenhar Quadrado");
		}

		public void PintarQuadrado()
		{
			Console.WriteLine("Pintando o quadrado");
		}
	}
}

