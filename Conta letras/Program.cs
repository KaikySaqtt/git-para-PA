using System;

namespace Conta_letras
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, vLetra, espa;
            int i, ContA=0;

            Console.Clear();
            Console.WriteLine("Me diga a frase: ");
            frase = Console.ReadLine();
            for (i = 0; i < frase.Length; i++) 
            {
                vLetra = frase.Substring(i, 1);
                switch (vLetra.ToLower())
                {
                    case "a":
                    case "ã":
                    case "á":
                        {
                            ContA++;
                            break;
                        }
                    default:
                        break;
                }
                
            }
            Console.WriteLine($"A frase que foi digitaa tem {frase.} caracteres.");
            Console.WriteLine($"E eu consegui encontra um total de {ContA} vogais 'a' ");

        }
    }
}
