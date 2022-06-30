string texto = "hahah";

try
{
    int numero = Convert.ToInt32(texto);

    int resultado = 100 / numero;

    Console.WriteLine($"O resultado de 100 divido por {numero} é: {resultado}");
}

catch (FormatException)
{
    Console.WriteLine("O formato do número informado é inválido. Informe outro valor. Por gentileza.");
}

catch (DivideByZeroException)
{
    Console.WriteLine("O número informado não pode ser zero, informe outro valor. Por gentileza.");
}

catch (Exception ex)
{
    Console.WriteLine($"Execeção mais abrangente. A mensagem da excecão é: '{ex.Message}'");
}