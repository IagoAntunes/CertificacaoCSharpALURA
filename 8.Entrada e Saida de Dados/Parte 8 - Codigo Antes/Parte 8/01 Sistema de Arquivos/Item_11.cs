using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_11 //Trabalhando com caminhos
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //Descobrir o caminho da pasta "Meus Documentos"
            //Combinar caminho da pasta "Meus Documentos" com arquivo "alura.txt"
            //Obter somente o nome do diretório do arquivo
            //Obter somente o nome do arquivo
            //Obter a extensão do arquivo
            //Modificar a extensão do arquivo


            var meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Console.WriteLine("Meus documentos: {0}",meusDocumentos);
            var caminhoCompleto = Path.Combine(meusDocumentos,"alura.txt");
            Console.WriteLine("CaminhoCompleto: {0}",caminhoCompleto);
            var somenteNomeDiretorio = Path.GetDirectoryName(caminhoCompleto);
            Console.WriteLine("Somente Nome Diretorio {0}",somenteNomeDiretorio);
            var somenteNomeArquivo = Path.GetFileName(caminhoCompleto);
            Console.WriteLine("Somente Nome Arquivo {0}", somenteNomeArquivo);
            var extensaoArquivo = Path.GetExtension(caminhoCompleto);
            Console.WriteLine("Extensao Arquivo: {0}",extensaoArquivo);

            caminhoCompleto = Path.ChangeExtension(caminhoCompleto,"xyz");
            Console.WriteLine("Nova extenssao {0}",caminhoCompleto);

        }
    }
}
