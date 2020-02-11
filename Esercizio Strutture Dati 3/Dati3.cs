using System;
using System.IO;

namespace Esercizio_Strutture_Dati_3
{
    class Dati3
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il nome del file sorgente: ");
            string name = $"{ Console.ReadLine() }";
            Console.Write("Inserisci il nome del nuovo file: ");
            string d = $"{ Console.ReadLine() }";
            if (File.Exists(name))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(name))
                    {
                        using (StreamWriter sw = new StreamWriter(d))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
                catch { }
            }
            else
            {
                Console.WriteLine("Non c'è il file sorgente");
                Console.ReadLine();
            }
        }
    }
}
