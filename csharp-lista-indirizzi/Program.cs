using csharp_lista_indirizzi;
using System;
using System.IO;
 
namespace csharplistaindirizzi
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Federico\Documents\Development\csharp-lista-indirizzi\csharp-lista-indirizzi\data\my-addresses.csv";

            /* LEGGERE UN FILE
             *  
             *  1) string file = File.ReadAllText(path);
             *   Console.WriteLine(file);
             * 
             *  2) StreamReader file = File.OpenText(path);
             *   while (!file.EndOfStream)
             *   {
             *   string riga = file.ReadLine();
             *      Console.WriteLine(riga);
             *   }
             *   file.Close();
             *
             *
             *  SCRIVERE SU UN FILE
             *  
             *  if (!File.Exists(path))
             *  {
                    StreamWriter file = File.CreateText(path);
                    file.WriteLine("Hello");
                    file.WriteLine("And");
                    chiudo il mio file
                    file.Close();
                }
             **/
            List<Clienti> myClient = new List<Clienti>();

            try
            {
                StreamReader file = File.OpenText(path);
                int i = 0;
                Console.WriteLine("Ecco la lista dei clienti nel file originale :");
                Console.WriteLine();
                while (!file.EndOfStream)
                {
                    string righe = file.ReadLine();                  // ogni singola riga, con ciclo, si stampano tutte le righe del file
                    i++;
                    if (i > 1)                                          // Non prendo l'header della tabella
                    {
                        string[] splitRiga = righe.Split(',');

                        if (splitRiga.Length < 6)
                        {
                            Console.WriteLine($"{i-1} C'è qualche campo mancante");
                        }
                        else
                        {
                        string name = splitRiga[0].TrimStart(new char[]{' ', ',' });
                        string lastname= splitRiga[1];
                        string address = splitRiga[2];
                        string city = splitRiga[3];
                        string province = splitRiga[4];
                        string zip = splitRiga[5];

                        Clienti newCliente = new Clienti(name, lastname, address, city, province, zip);
                        myClient.Add(newCliente);

                        Console.WriteLine($"{i-1}: {righe}");

                             
                        }
                        //Console.WriteLine(name);
                    }
                }
                file.Close();



                Console.WriteLine(myClient.Count);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            for (int i = 0; i < myClient.Count; i++)
            {
                Console.WriteLine($"{i+1} {myClient[i]}");
            }
        }
    }
}

/*
 Oggi esercitazione sui file, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.*/