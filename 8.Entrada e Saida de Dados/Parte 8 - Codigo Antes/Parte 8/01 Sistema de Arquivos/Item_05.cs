using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_05 //A classe File
    {
        static void XVMain(string[] args)
        {
            //TAREFAS: GRAVAR E LER DADOS DE UM ARQUIVO USANDO A CLASSE File

            string conteudoInicial = "Conteudo Inicial do Arquivo";
            string conteudoAdicional = " Conteudo Adicional ao Arquivo";
            File.WriteAllText("Arquivo.txt",conteudoInicial);
            File.AppendAllText("Arquivo.txt", conteudoAdicional);
            if (File.Exists("Arquivo.txt"))
            {
                Console.WriteLine("O arquivo ja existe . . .");
            }
            //Ler arquivo
            string conteudo = File.ReadAllText("Arquivo.txt");
            Console.WriteLine(conteudo);
            //Copiar arquivo
            File.Copy("Arquivo.txt", "CopiaArquivo.txt",true);
            Console.WriteLine(File.ReadAllText("CopiaArquivo.txt"));
            using (var leitor = File.OpenText("CopiaArquivo.txt"))
            {
                var texto = leitor.ReadToEnd();
                Console.WriteLine(texto);
            }


            Console.ReadKey();
        }
    }
}
