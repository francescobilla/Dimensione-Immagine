using System;

namespace Dimensione_Immagine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci altezza immagine:");
            int altezza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci larghezza immagine:");
            int larghezza = Convert.ToInt32(Console.ReadLine());
            Double biancoenero = ((altezza * larghezza) *  0.125) * 1024;
            Console.WriteLine($"l'immagine bianco e nero pesa: {biancoenero}KB.");
            int colori256 = ((altezza * larghezza) * 1) * 1024;
            Console.WriteLine($"l'immagine con 256 colori pesa: {colori256}KB.");
            int colori65000 = ((altezza * larghezza) * 2) * 1024;
            Console.WriteLine($"l'immagine con 65000 colori pesa: {colori65000}KB.");
            int truecolor = ((altezza * larghezza) * 3) * 1024;
            Console.WriteLine($"l'immagine con 65000 colori pesa: {truecolor}KB.");
        }
    }
}
