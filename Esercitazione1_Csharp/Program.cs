using System;

namespace Esercitazione1_Csharp
{
    public class Program
    {
        // HELLO WORLD
        //static void Main(string[] arg)
        //{
        //    Console.WriteLine("Hello World!!!");
        //}

        // CHIEDI A UTENTE 2 NUMERI E STAMPA LA SOMMA
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci Secondo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int somma = num1 + num2;
            Console.WriteLine("La somma dei numeri inseriti è: " + somma);

            // VERSIONE CON GESTIONE ERRORI
            Console.Write("Inserisci il primo numero: ");
            bool isNum3Valid = int.TryParse(Console.ReadLine(), out int num3);

            Console.Write("Inserisci il secondo numero: ");
            bool isNum4Valid = int.TryParse(Console.ReadLine(), out int num4);

            if (isNum3Valid && isNum4Valid)
            {
                int somma2 = num3 + num4;
                Console.WriteLine($"La somma dei numeri inseriti è: {somma2}");
            }
            else
            {
                Console.WriteLine("Errore: uno dei valori inseriti non è un numero valido.");
            }
        }
    }
}