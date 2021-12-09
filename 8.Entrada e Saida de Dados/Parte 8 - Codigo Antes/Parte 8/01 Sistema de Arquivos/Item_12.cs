using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_12 //Procurando e listando arquivos
    {
        static void xMain(string[] args)
        {
            //TAREFAS:
            //Obter o diretório de início do projeto
            //Listar todos os diretórios do projeto
            //Listar todos os arquivos csharp (.cs) do projeto


            DirectoryInfo diretorioInicial = new DirectoryInfo(@"..\..\..");
            diretorioInicial.GetDirectories();
            ListarDiretorios(diretorioInicial);

        }

        private static void ListarDiretorios(DirectoryInfo diretorioInicial)
        {
            foreach (var diretorio in diretorioInicial.GetDirectories())
            {
                Console.WriteLine(diretorio.FullName);

                foreach (var arquivo in diretorio.GetFiles("*.cs"))
                {
                    Console.WriteLine(arquivo.FullName);
                }

                ListarDiretorios(diretorio);
            }
        }
    }
}
/*04 Gerenciando Diretorios
 * Manipular diretorios com a classe Directory
 * CreateDirectory e Delete
 * Obter informações de diretório
 * A classe DirectoryInfo
 * Diretorios de pastas espedciais do sistema
 * Combinar diretorios com Path.Combine
 * Pesquisar arquivos em diretorio com Directory.GetFiles
 * Função Recursiva em diretorios
 */