using System;

internal class Program
{
    static Sort sortownia;
    static void Main(string[] args)
    {
        sortownia = new Sort();
        Console.WriteLine("Pokaż przed sortowaniem: ");
        sortownia.PokazTablice();
        sortownia.Sortuj();
        Console.WriteLine("\nPokaż po sortowaniu: ");
        sortownia.PokazTablice();
        Console.ReadKey();
    }

}
