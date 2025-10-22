using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Esercitazione1_Csharp
{
    public class Program
    {
        // HELLO WORLD
        //static void Main(string[] arg)
        //{
        //    Console.WriteLine("Hello World!!!");
        //}

        // snack1 - CHIEDI A UTENTE 2 NUMERI E STAMPA LA SOMMA
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Inserisci il primo numero: ");
        //    int num1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Inserisci Secondo numero: ");
        //    int num2 = int.Parse(Console.ReadLine());

        //    int somma = num1 + num2;
        //    Console.WriteLine("La somma dei numeri inseriti è: " + somma);

        //    // VERSIONE CON GESTIONE ERRORI
        //    Console.Write("Inserisci il primo numero: ");
        //    bool isNum3Valid = int.TryParse(Console.ReadLine(), out int num3);

        //    Console.Write("Inserisci il secondo numero: ");
        //    bool isNum4Valid = int.TryParse(Console.ReadLine(), out int num4);

        //    if (isNum3Valid && isNum4Valid)
        //    {
        //        int somma2 = num3 + num4;
        //        Console.WriteLine($"La somma dei numeri inseriti è: {somma2}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Errore: uno dei valori inseriti non è un numero valido.");
        //    }
        //}

        //  snack2 - CALCOLA AREA E PERIMETRO DEL RETTANGOLO
        //static void Main(string[] arg)
        //{
        //    Console.WriteLine("Inserisci la lunghezza del rettangolo: ");
        //    int lunghezza = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Inserisci la larghezza del rettangolo: ");
        //    int larghezza = int.Parse(Console.ReadLine());

        //    int area = lunghezza * larghezza;
        //    int perimetro = 2 * (lunghezza + larghezza);
        //    Console.WriteLine("L'area del rettangolo è: " + area);
        //    Console.WriteLine("Il perimetro del rettangolo è: " + perimetro);

        //    // VERSIONE CON GESTIONE ERRORI
        //    Console.Write("Inserisci la lunghezza del rettangolo: ");
        //    bool isLengthValid = double.TryParse(Console.ReadLine(), out double length);

        //    Console.Write("Inserisci la larghezza del rettangolo: ");
        //    bool isWidthValid = double.TryParse(Console.ReadLine(), out double width);

        //    if (isLengthValid && isWidthValid)
        //    {
        //        double area2 = length * width;
        //        double perimeter = 2 * (length + width);
        //        Console.WriteLine($"L'area del rettangolo è: {area2}");
        //        Console.WriteLine($"Il perimetro del rettangolo è: {perimeter}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Errore: uno dei valori inseriti non è un numero valido.");
        //    }
        //}

        // snack3 - CREA UN ARRAY DI 10 NUMERI E STAMPA SOLO I NUMERI DISPARI
        static void Main(string[] arg)
        {
            int numeroElementi = 5;
            int[] arrayNum = new int[numeroElementi];

            Random generatore = new Random();  // generatore di num casuale
            for (int i=0; i<numeroElementi; i++)
            {
                int numero = generatore.Next(1, 11); // genera un numero casuale tra 1 e 10
                arrayNum[i] = numero;  //salva num in array
            }
            // visualizza array generato
            foreach (int numero in arrayNum)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Numeri dispari nell'array:");
            foreach (int numero in arrayNum)
            {
                if (numero % 2 != 0) // verifica se il numero è dispari
                {
                    Console.WriteLine(numero); // stampa il numero dispari
                }
            }
        }
    }
}