using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Listings
{
    class Item_04 //Trabalhando com arquivos comprimidos
    {
        static void XIVMain(string[] args)
        {
            //Usar arquivo compactado Texto.zip no lugar do arquivo saida.txt

            //COMPACTADOR
            using (FileStream fluxoArquivo = new FileStream("Texto.zip", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (GZipStream compactador = new GZipStream(fluxoArquivo, CompressionMode.Compress))
                {
                    using (StreamWriter gravadorFluxo = new StreamWriter(compactador))
                    {
                        gravadorFluxo.Write("Olá, Alura! (gravado com StreamWriter)");
                    }
                }
            }
            //DESCOMPATADOR
            using (FileStream fluxoArquivo = new FileStream("Texto.zip", FileMode.Open, FileAccess.Read))
            {
                using (GZipStream desconpactador = new GZipStream(fluxoArquivo, CompressionMode.Decompress))
                {
                    using (StreamReader leitorFluxo = new StreamReader(desconpactador))
                    {
                        string textoLido = leitorFluxo.ReadToEnd();
                        Console.WriteLine("Texto lido: {0}", textoLido);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
/*02
 * Gravar texto com StreamWriter e Write
 * Ler texto com StreamReader e ReadToEnd
 * Gravar arquivos compactado com GZipStream
 * A classe File
 * Gravar texto com metodo WriteAllText
 * Adicionar texto com metodo AppendAllText
 * Ler texto com ReadAllText
 * Capturar excecoes de stream
 */
