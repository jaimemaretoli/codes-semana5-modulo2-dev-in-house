using System;
using exemploMaiorHeranca.Entities;

class Program
{
    public static void Main()
    {
        Animal animal1 = new Animal("anima1");
        Mamifero mamifero1 = new Mamifero("mamifero", 40);
        Cachorro cachorro1 = new Cachorro("Jordan", 20, true);
        Vaca vaca1 = new Vaca("Mimosa", 5, false);

        // Animal 1
        Console.WriteLine($"O nome do animal 1, é: {animal1.nome}");

        Console.WriteLine(mamifero1.nome);

        mamifero1.Imprime();
        mamifero1.Falar("qualquer um");
        mamifero1.Correr();

        Console.WriteLine($"O nome do cachorro é: {cachorro1.tipoLatido}");

        cachorro1.Falar("auu");

        vaca1.Ordenhar();


    }
}
