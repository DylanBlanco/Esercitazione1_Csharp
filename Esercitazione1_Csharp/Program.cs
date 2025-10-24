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

        //// snack3 - CREA UN ARRAY DI 10 NUMERI E STAMPA SOLO I NUMERI DISPARI
        //static void Main(string[] arg)
        //{
        //    int numeroElementi = 5;
        //    int[] arrayNum = new int[numeroElementi];

        //    Random generatore = new Random();  // generatore di num casuale
        //    for (int i=0; i<numeroElementi; i++)
        //    {
        //        int numero = generatore.Next(1, 11); // genera un numero casuale tra 1 e 10
        //        arrayNum[i] = numero;  //salva num in array
        //    }
        //    // visualizza array generato
        //    foreach (int numero in arrayNum)
        //    {
        //        Console.WriteLine(numero);
        //    }

        //    Console.WriteLine("Numeri dispari nell'array:");
        //    foreach (int numero in arrayNum)
        //    {
        //        if (numero % 2 != 0) // verifica se il numero è dispari
        //        {
        //            Console.WriteLine(numero); // stampa il numero dispari
        //        }
        //    }
        //}


        //// snack4 - CHIEDI ALL'UTENTE UN NUMERO FINO A QUANDO NON INSERISCE UN NUMERO PARI
        //static void Main(string[] arg)
        //{
        //    Console.WriteLine("Inserisci un numero: ");

        //    int numUtente = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Hai inserito: " + numUtente);
        //    while (numUtente % 2 != 0)
        //    {
        //        Console.WriteLine("Il numero inserito è dispari. Inserisci un numero pari: ");
        //        numUtente = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Hai inserito: " + numUtente);
        //    }
        //}


        //// snack5 - CALCOLA LA SOMMA E LA MEDIA DI NUMERI INSERITI DALL'UTENTE FINO A QUANDO NON INSERISCE 0
        //static void Main(string[] arg)
        //{
        //    Console.WriteLine("Inserisci il primo numero: ");
        //    int numUtente1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Inserisci il secondo numero: ");
        //    int numUtente2 = int.Parse(Console.ReadLine());

        //    if (numUtente1 != 0 && numUtente2 != 0)
        //    {
        //        int somma = numUtente1 + numUtente2;
        //        Console.WriteLine("la somma dei numeri è:" + somma);

        //        double media = somma / 2;
        //        Console.WriteLine("la media dei numeri è:" + media);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hai inserito 0, impossibile calcolare somma e media.");
        //    }
        //}


        //// snack6 - STAMPA I NUMERI DA 1 A 100, SOSTITUENDO I MULTIPLI DI 3 CON "Fizz", I MULTIPLI DI 5 CON "Buzz" E I MULTIPLI DI ENTRAMBI CON "FizzBuzz"
        //static void Main(string[] arg)
        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            Console.WriteLine("FizzBuzz");
        //        }
        //        else if (i % 3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            Console.WriteLine("Buzz");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}


        //// snack7 - CHIEDI ALL'UTENTE DI INSERIRE UNA PAROLA E STAMPA LA PAROLA AL CONTRARIO
        //static void Main(string[] arg)
        //{
        //    Console.WriteLine("Inserisci una parola: ");
        //    string parolaUtente = Console.ReadLine();

        //    char[] arrParola = parolaUtente.ToCharArray();

        //    Console.Write(string.Join(",", arrParola));

        //    Array.Reverse(arrParola);

        //    string parolaInversa = new string(arrParola);

        //    Console.WriteLine("La parola al contrario è: " + parolaInversa);
        //}

        //// snack8 - CREA UN ARRAY DI 10 NUMERI CASUALI E STAMPA IL NUMERO PIU' GRANDE E IL NUMERO PIU' PICCOLO
        //static void Main(string[] arg)
        //{
        //    Console.WriteLine("Inserisci il num di elementi da creare:");
        //    int numElementi = int.Parse(Console.ReadLine());

        //    Random numRandom = new Random();

        //    int[] arrayNum = new int[numElementi];

        //    for (int i = 0; i < numElementi; i++)
        //    {
        //        arrayNum[i] = numRandom.Next(1, 11);
        //    }
        //    Console.WriteLine("Array generato:" + string.Join(",", arrayNum));

        //    int numMax = arrayNum[0];
        //    int numMin = arrayNum[0];
        //    for (int i=0; i<arrayNum.Length; i++)
        //    {
        //        if (arrayNum[i] > numMax)
        //        {
        //            numMax = arrayNum[i];
        //        }
        //        if (arrayNum[i] < numMin)
        //        {
        //            numMin = arrayNum[i];
        //        }
        //    }
        //    Console.WriteLine("Il numero più grande è: " + numMax);
        //    Console.WriteLine("Il numero più piccolo è: " + numMin);
        //}


        //// snack9 - CHIEDI ALL'UTENTE DI INSERIRE UNA FRASE E UNA PAROLA, POI STAMPA LA FRASE SENZA LA PAROLA INSERITA
        //static void Main(string[] arg)
        //{
        //    Console.WriteLine("Inserisci una frase: ");
        //    string fraseUtente = Console.ReadLine();

        //    Console.WriteLine("Inserisci una parola da rimuovere dalla frase: ");
        //    string parolaDaRimuovere = Console.ReadLine();

        //    string fraseModificata = fraseUtente.Replace(parolaDaRimuovere, "");
        //    Console.WriteLine("Frase modificata: " + fraseModificata);
        //}

        // snack10 - CREA DUE ARRAY DI 5 NUMERI E CREA UN TERZO ARRAY CHE CONTIENE LA SOMMA DEI NUMERI DEI DUE ARRAY NELLA STESSA POSIZIONE
        static void Main(string[] arg)
        {
            int dimensioneArray = 5;
            int[] array1 = new int[dimensioneArray];
            int[] array2 = new int[dimensioneArray];
            int[] arraySomma = new int[dimensioneArray];

            Random generatore = new Random();
            for (int i = 0; i < dimensioneArray; i++)
            {
                array1[i] = generatore.Next(1, 11);
                array2[i] = generatore.Next(1, 11);
                arraySomma[i] = array1[i] + array2[i];
            }
            Console.WriteLine("Array 1: " + string.Join(", ", array1));
            Console.WriteLine("Array 2: " + string.Join(", ", array2));
            Console.WriteLine("Array Somma: " + string.Join(", ", arraySomma));
        }
    }
}