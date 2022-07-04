using System;

namespace Resolucao_Exercicio_2_3_4_Semana_5_Modulo_2
{
	public class Program
	{
		public static void Main(string[] args)
        {
			Cartao objCartao = new Cartao("master", 1000.00, 0.02);

			// Upcasting
			Cartao objCartaoVR = new CartaoVR("vr", 500.00, 0.05);
			Cartao objCartaoVA = new CartaoVA("va", 400.00, 0.10);
			Cartao objCartaoVT = new CartaoVT("vt", 400.00, 0.01);

            Console.WriteLine("\n-------- Objeto Cartao ---------\n" +
							$"- Bandeira: {objCartao.bandeira}\n" +
							$"- Saldo: {objCartao.saldo}\n" +
							$"- Taxa: {objCartao.valorTaxa * 100}%\n" +
                            $"- Valor referente a taxa: {objCartao.VerificarValorTaxaCartao(objCartao.saldo)}");

			Console.WriteLine("\n-------- Objeto CartaoVR ---------\n" +
							$"- Bandeira: {objCartaoVR.bandeira}\n" +
							$"- Saldo: {objCartaoVR.saldo}\n" +
							$"- Taxa: {objCartaoVR.valorTaxa * 100}%\n" +
							$"- Valor referente a taxa: {objCartaoVR.VerificarValorTaxaCartao(objCartaoVR.saldo)}");

			Console.WriteLine("\n-------- Objeto CartaoVA ---------\n" +
							$"- Bandeira: {objCartaoVA.bandeira}\n" +
							$"- Saldo: {objCartaoVA.saldo}\n" +
							$"- Taxa: {objCartaoVA.valorTaxa * 100}%\n" +
							$"- Valor referente a taxa: {objCartaoVA.VerificarValorTaxaCartao(objCartaoVA.saldo)}");

			Console.WriteLine("\n-------- Objeto CartaoVT ---------\n" +
							$"- Bandeira: {objCartaoVT.bandeira}\n" +
							$"- Saldo: {objCartaoVT.saldo}\n" +
							$"- Taxa: {objCartaoVT.valorTaxa * 100}%\n" +
							$"- Valor referente a taxa: {objCartaoVT.VerificarValorTaxaCartao(objCartaoVT.saldo)}");

			// Downcastings

			CartaoVR objCartaoVRDowncasting = new CartaoVR();
			objCartaoVRDowncasting = (CartaoVR)objCartaoVR;

			CartaoVA objCartaoVADowncasting = new CartaoVA();
			objCartaoVADowncasting = (CartaoVA)objCartaoVA;

			CartaoVT objCartaoVTDowncasting = new CartaoVT();
			objCartaoVTDowncasting = (CartaoVT)objCartaoVT;
		}
	}
}