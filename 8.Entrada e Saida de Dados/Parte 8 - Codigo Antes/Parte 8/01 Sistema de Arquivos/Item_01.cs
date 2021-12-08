using System;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_01 //Usando o FileStream
    {
        static void Main(string[] args)
        {
            //Gravando um arquivo

            FileStream fluxoSaida =
                new FileStream("ArquivoSaida.txt",FileMode.Create,FileAccess.Write);

            string mensagemSaida = "Ola Alura, bom dia";
            
            byte[] array = Encoding.UTF8.GetBytes(mensagemSaida);
            int posicao = 0;
            int tamanho = mensagemSaida.Length;
            fluxoSaida.Write(array,posicao,tamanho);
            fluxoSaida.Close();

            FileStream fluxoEntrada=
                new FileStream("ArquivoSaida.txt",FileMode.Open,FileAccess.Read);

            byte[] bytesLidos = new byte[fluxoEntrada.Length];

            fluxoEntrada.Read(bytesLidos,posicao,(int)fluxoEntrada.Length);
            string texto = Encoding.UTF8.GetString(bytesLidos);
            fluxoEntrada.Close();
            Console.WriteLine("Mensagem Lida: "+texto);
            

            Console.ReadKey();
        }
    }
}
/*Abrir um fluxo de arquivo com Filetream
 * FileMode.Open e FileAccess.Read
 * Ler array de bytes com o metodo Read
 * Pular posicoes com metodos seek e position
 * Abrir um fluxo de escrita com file stream
 * filemode.create e fileAccess.write
 * Os metodos write e close
 * Definir escopo do FileStream e liberand orecursos com using
 */