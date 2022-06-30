using System;

namespace exemploAulaUpcastingDowncasting
{
	public class Circulo : Forma
	{
		public Circulo()
		{
		}

		public override void Desenhar()
		{
            Console.WriteLine("Desenhar Ciruclo");
		}

		public void PintarCirculo()
		{
            Console.WriteLine("Pintando o circulo");
		}
	}
}

